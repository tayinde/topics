using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task CreateTopic(string user, string token, string title, string keywords, string content)
		{
			
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Topics") as MongoDatabaseBase;
			if (await Account.Exists(user, token))
			{
				string topicId = user.CreateToken();
				while (topicId == token) topicId = user.CreateToken();
				database.CreateCollection(topicId);

				BsonDocument topicData = new BsonDocument
				{
					{ "id", topicId },
					{ "title", title },
					{ "keywords", keywords },
					{ "content", content },
					{ "author", user },
					{ "date", DateTime.Now.ToString() },
				};
				
				database.GetCollection<BsonDocument>(topicId).InsertOne(topicData);
				// Comments database creation
				MongoDatabaseBase commentsDatabase = new MongoClient(Secrets.DatabaseKey).GetDatabase("Comments") as MongoDatabaseBase;
				commentsDatabase.CreateCollection(topicId);
				
			}
		}
	}
}
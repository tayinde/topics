using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task CreateTopic(string user, string token, string title, string keywords, string content, string topicId)
		{
			
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Topics") as MongoDatabaseBase;
			if (await Account.Exists(user, token))
			{
				while (topicId == token) topicId = user.CreateToken();
				database.CreateCollection(topicId);

				var date = DateTime.Now;
				BsonDocument topicData = new BsonDocument
				{
					{ "date", date.ToString() },
					{ "num_date", ((int)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds).ToString() },
					{ "id", topicId },
					{ "title", title },
					{ "keywords", keywords },
					{ "content", content },
					{ "author", user },
				};
				
				database.GetCollection<BsonDocument>(topicId).InsertOne(topicData);
				// Comments database creation
				MongoDatabaseBase commentsDatabase = new MongoClient(Secrets.DatabaseKey).GetDatabase("Comments") as MongoDatabaseBase;
				commentsDatabase.CreateCollection(topicId);
				
			}
		}
	}
}
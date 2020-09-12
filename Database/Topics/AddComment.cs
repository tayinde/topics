using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task AddComment(string user, string token, string topicId, string content, string date)
		{
			content = content.Replace("\n", "[br]");
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Topics") as MongoDatabaseBase;
			if (await Account.Exists(user, token))
			{
				MongoDatabaseBase commentsDatabase = new MongoClient(Secrets.DatabaseKey).GetDatabase("Comments") as MongoDatabaseBase;
				var collection = commentsDatabase.GetCollection<BsonDocument>(topicId);
				
				BsonDocument topicData = new BsonDocument
				{
					{ "content", content },
					{ "author", user },
					{ "date", date },
				};
				await collection.InsertOneAsync(topicData);
			}
		}
	}
}
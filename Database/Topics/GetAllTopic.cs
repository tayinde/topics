using MongoDB.Driver;
using MongoDB.Bson;
using System.Globalization;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task<List<Dictionary<string, string>>> GetAllTopics()
		{
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Topics") as MongoDatabaseBase;
			List<Dictionary<string, string>> topics = new List<Dictionary<string, string>>();

			List<string> data = database.ListCollectionNames().ToList();

			foreach (string collectionName in data)
			{
				FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("id", collectionName);
				#nullable enable
				BsonDocument? collection = (await database.GetCollection<BsonDocument>(collectionName).FindAsync(filter)).FirstOrDefault();
				if (collection != null)
				{
					topics.Add(new Dictionary<string, string>
					{
						{ "id", collection["id"].AsString },
						{ "author", collection["author"].AsString },
						{ "date", collection["date"].AsString },
						{ "num_date", collection["num_date"].AsString },
						{ "title", collection["title"].AsString },
						{ "keywords", collection["keywords"].AsString },
						{ "content", collection["content"].AsString },
						{ "profile_picture", await Account.GetProperty(collection["author"].AsString, "profile_picture") }
					});
				}
			}
			topics = (from item in topics orderby item["num_date"] descending select item).ToList();
			return topics;
		}
	}
}
using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task<Dictionary<string, Dictionary<string, string>>> GetAllTopics()
		{
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Topics") as MongoDatabaseBase;
			Dictionary<string, Dictionary<string, string>> topics = new Dictionary<string, Dictionary<string, string>>();

			List<string> data = database.ListCollectionNames().ToList();

			foreach (string collectionName in data)
			{
				FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("id", collectionName);
				#nullable enable
				BsonDocument? collection = (await database.GetCollection<BsonDocument>(collectionName).FindAsync(filter)).FirstOrDefault();
				if (collection != null)
					topics.Add(collection["id"].AsString, new Dictionary<string, string>
					{
						{ "author", collection["author"].AsString },
						{ "date", collection["date"].AsString },
						{ "title", collection["title"].AsString },
						{ "keywords", collection["keywords"].AsString },
						{ "content", collection["content"].AsString },
						{ "profile_picture", await Account.GetProperty(collection["author"].AsString, "profile_picture") }
					});
			}
			return topics;
		}
	}
}
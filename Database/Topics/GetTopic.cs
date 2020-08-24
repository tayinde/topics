using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task<Dictionary<string, string>> GetTopic(string collectionName)
		{
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Topics") as MongoDatabaseBase;
			FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("id", collectionName);
			#nullable enable
			if (database != null)
			{
				BsonDocument? collection = (await database.GetCollection<BsonDocument>(collectionName).FindAsync(filter)).FirstOrDefault();
				if (collection != null)
				{
					return new Dictionary<string, string>
					{
						{ "result", "success" },
						{ "id", collection["id"].AsString },
						{ "author", collection["author"].AsString },
						{ "date", collection["date"].AsString },
						{ "title", collection["title"].AsString },
						{ "content", collection["content"].AsString },
						{ "profile_picture", await Account.GetProperty(collection["author"].AsString, "profile_picture") }
					};
				}
			}
			return new Dictionary<string, string> { { "result", "error" } };
		}
	}
}
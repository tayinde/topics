using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Topics.Database
{
	public static partial class Topics
	{
		public async static Task<List<BsonDocument>> GetAllComments(string topicId)
		{
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Comments") as MongoDatabaseBase;

			FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Empty;
			var collection = (await database.GetCollection<BsonDocument>(topicId).FindAsync(filter)).ToList();

			return collection;
		}
	}
}
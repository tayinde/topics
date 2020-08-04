using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;

namespace Topics.Database
{
	public class AccountFinder
	{
		public async static Task<string> Find(string user, string pwd)
		{
			if (user == null || pwd == null) return "invalid";
			MongoDatabaseBase database = new MongoClient(Secrets.DBKey).GetDatabase("Accounts") as MongoDatabaseBase;

			IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(user);
			FilterDefinition<BsonDocument> data = Builders<BsonDocument>.Filter.And
			(
				Builders<BsonDocument>.Filter.Eq("user", user),
				Builders<BsonDocument>.Filter.Eq("pwd", pwd)
			);

			try { return (await collection.FindAsync(data)).First().ToString(); } catch { return "invalid"; }
		} 
	}
}
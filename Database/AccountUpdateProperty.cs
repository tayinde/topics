using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace Topics.Database
{
	public partial class Account
	{
		public async static Task UpdateProperty(string user, string property, string value)
		{
			string OriginalUser = user;
			user = user.ToLower();
			if (user == null) return;
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Accounts") as MongoDatabaseBase;

			IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(user);

			FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("user", user);
			UpdateDefinition<BsonDocument> update = Builders<BsonDocument>.Update.Set(property, value);

			await collection.UpdateOneAsync(filter, update);
		} 
	}
}
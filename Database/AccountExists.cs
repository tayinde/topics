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
		public async static Task<bool> Exists(string user, string token)
		{
			string OriginalUser = user;
			user = user.ToLower();
			if (user == null || token == null) return false;
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Accounts") as MongoDatabaseBase;

			IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(user);
			FilterDefinition<BsonDocument> data = Builders<BsonDocument>.Filter.And
			(
				Builders<BsonDocument>.Filter.Eq("user", OriginalUser),
				Builders<BsonDocument>.Filter.Eq("token", token)
			);
			#nullable enable
			BsonDocument? result = (await collection.FindAsync(data)).FirstOrDefault();
			#nullable disable
			
			if (result != null) return true;
			else return false;
		} 
	}
}
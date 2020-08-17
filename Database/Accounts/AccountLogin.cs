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
		public async static Task<Dictionary<string, string>> Login(string user, string pwd)
		{
			string OriginalUser = user;
			user = user.ToLower();
			if (user == null || pwd == null) return new Dictionary<string, string>() { { "result", null } };
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Accounts") as MongoDatabaseBase;

			IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(user);
			FilterDefinition<BsonDocument> data = Builders<BsonDocument>.Filter.And
			(
				Builders<BsonDocument>.Filter.Eq("user", OriginalUser),
				Builders<BsonDocument>.Filter.Eq("pwd", pwd)
			);
			#nullable enable
			BsonDocument? result = (await collection.FindAsync(data)).FirstOrDefault();
			#nullable disable
			
			if (result != null)
				return new Dictionary<string, string>()
				{
					{ "user",  result["user"].AsString },
					{ "token", result["token"].AsString  },
					{ "result", "success" }
				};
			else
				return new Dictionary<string, string>()
				{
					{ "result", "invalid" }
				};
		} 
	}
}
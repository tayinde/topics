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
		public async static Task<string> GetProperty(string user, string property)
		{
			#nullable disable
			try
			{
				string OriginalUser = user;
				user = user.ToLower();
				if (user == null) return "";
				MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Accounts") as MongoDatabaseBase;

				IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(user);
				FilterDefinition<BsonDocument> data = Builders<BsonDocument>.Filter.Eq("user", OriginalUser);
				#nullable enable
				BsonDocument? result = (await collection.FindAsync(data)).FirstOrDefault();
				#nullable disable
				
				return result == null ? "" : result[property].AsString;
			} catch { return ""; }
		} 
	}
}
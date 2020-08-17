using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Threading.Tasks;
using System;

namespace Topics.Database
{
	public partial class Account
	{
		public async static Task<Dictionary<string, string>> Create(string user, string pwd)
		{
			string OriginalUsername = user;
			BsonDocument FindExistence = new BsonDocument()
			{
				{ "user", OriginalUsername }
			};
			user = user.ToLower();
			string ValidUsername = user.Validate();
			string ValidPassword = pwd.ValidatePassword();
			MongoDatabaseBase database = new MongoClient(Secrets.DatabaseKey).GetDatabase("Accounts") as MongoDatabaseBase;
			
			if (ValidUsername != "success") return new Dictionary<string, string>()
			{
				{"result", "invalid"},
				{"issue", ValidUsername}
			};
			else if (ValidPassword != "success") return new Dictionary<string, string>()
			{
				{"result", "invalid"},
				{"issue", ValidPassword}
			};
			else if ((await database.GetCollection<BsonDocument>(user).FindAsync(FindExistence)).FirstOrDefault() != null) return new Dictionary<string, string>()
			{
				{ "result", "taken" }
			};
			else
			{
				database.CreateCollection(user);
				string token = OriginalUsername.CreateToken();
				BsonDocument data = new BsonDocument()
				{
					{ "user", OriginalUsername },
					{ "pwd", pwd},
					{ "token", token },
					{ "profile_picture", "/images/default_profile_picture.jpg"}
				};
				await database.GetCollection<BsonDocument>(user).InsertOneAsync(data);
				return new Dictionary<string, string>()
				{
					{ "user", OriginalUsername },
					{ "token", token  },
					{ "result", "success" }
				};
			}
		} 
	}
}
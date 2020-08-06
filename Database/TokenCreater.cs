using System.Linq;
using System;

namespace Topics.Database
{
	public static class Token
	{
		/// <summary>Creates a sequence of random characters partly with the use of a username</summary>
		public static string CreateToken(this string user)
		{
			string token = "";
			Random random = new Random();
			user += user.Reverse() + random.Next(1, 1000).ToString();
			for (int i = 0; i < (user.Length <= 20 ? user.Length : 20); i++)
			{
				int num = random.Next(65, 91);
				token += (user[random.Next(user.Length)]).ToString() + (char) num;
			}
			return token;
		}
	}
}
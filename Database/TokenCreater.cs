using System.Linq;
using System.Web;
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
			user += string.Join("", user.Reverse());
			for (int i = 0; i < (user.Length <= 20 ? user.Length : 20); i++)
			{
				int num = random.Next(0, 25);
				int index = random.Next(0, user.Length - 1);
				token += user.ElementAt(index) + ((char) ((num > 12 ? 'A' : 'a') + num)).ToString() + (num > 12 ? random.Next(100) as dynamic : "");
			}
			return token;
		}
		public static string CreateImageName(this string user)
		{
			string token = "";
			Random random = new Random();
			user += user.Reverse().ToString();
			for (int i = 0; i < (user.Length <= 20 ? user.Length : 20); i++)
			{
				int num = random.Next(0, 25);
				token += user[random.Next(0, user.Length - 1)] + ((char) ('a' + num)).ToString();
			}
			return token;
		}
	}
}
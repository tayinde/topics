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
			user += user.Reverse();
			for (int i = 0; i < (user.Length <= 20 ? user.Length : 20); i++)
			{
				int num = random.Next(0, 25);
				token += (user[random.Next(0, user.Length - 1)]).ToString() + (char) ('a' + num);
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
				token += user[random.Next(0, user.Length - 1)] + (char) ('a' + num);
			}
			return HttpUtility.HtmlEncode(token);
		}
	}
}
using System.Text.RegularExpressions;
using System.Web;

namespace Topics.Database
{
	public static class Username
	{
		///<summary>Checks for spaces, length of username, and symbols</summary>
		public static string Validate(this string user)
		{
			user = HttpUtility.UrlEncode(user);
			if (string.IsNullOrWhiteSpace(user)) return "Username cannot be empty.";
			Regex symbols = new Regex(@"[!@#\$% \^&\+\\\*(),\/\]\[\-=\|><\?~`{}'" + "\"" + @";:]");
			if (symbols.Match(user).Success) return "Usernames cannot have symbols or spaces.";
			else if (user.Length < 5 || user.Length > 25) return "Your username should be 5-25 characters long";
			else return "success";
		}
	}
}
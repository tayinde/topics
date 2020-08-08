using System.Text.RegularExpressions;

namespace Topics.Database
{
	public static class Username
	{
		///<summary>Checks for spaces, length of username, and symbols</summary>
		public static string Validate(this string user)
		{
			if (string.IsNullOrWhiteSpace(user)) return "Username cannot be empty.";
			Regex symbols = new Regex(@"[!@#\$% \^&\+\\\*(),\/\]\[\-=\|><\?~`{}'" + "\"" + @";:]");
			if (symbols.Match(user).Success) return "Usernames cannot have symbols or spaces.";
			else if (user.Length < 3 || user.Length > 25) return "Your username should be 3-25 characters long";
			else return "success";
		}
	}
}
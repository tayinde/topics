using System.Text.RegularExpressions;

namespace Topics.Database
{
	public static class Password
	{
		///<summary>Checks for spaces, length of username, and symbols</summary>
		public static string ValidatePassword(this string pwd)
		{
			if (pwd.Length < 4) return "Your password must be 4 or more characters long.";
			else return "success";
		}
	}
}
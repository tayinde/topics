using Microsoft.AspNetCore.Http;

namespace Topics.Models
{
	public class IndexViewModel
	{
		public bool LoggedIn = false;
		public string Username;
		public string Token;
		public string ProfilePicture;
	}
}
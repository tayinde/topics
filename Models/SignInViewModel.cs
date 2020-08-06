using Microsoft.AspNetCore.Mvc;

namespace Topics.Models
{
	[IgnoreAntiforgeryToken]
	[ResponseCache(VaryByHeader = "User-Agent", Duration = 300, NoStore = false, Location = ResponseCacheLocation.Any)]
	public class SignInViewModel
	{
		public SignInViewModel() {}
		public SignInViewModel(string Error) => this.Error = Error;
		public string Error;
	}
}
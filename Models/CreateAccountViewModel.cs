using Microsoft.AspNetCore.Mvc;

namespace Topics.Models
{
	public class CreateAccountViewModel
	{
		public CreateAccountViewModel() {}
		public CreateAccountViewModel(string Error) { this.Error = Error; }
		public string Error {get; set;}
	}
}
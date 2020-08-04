namespace Topics.Models
{
	public class SignInViewModel
	{
		public SignInViewModel() {}
		public SignInViewModel(string Error) => this.Error = Error;
		public string Error = null;
	}
}
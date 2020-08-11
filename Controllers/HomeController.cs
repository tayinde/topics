using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Web;
using System.Threading;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.ResponseCaching;
using System.Linq;
using MongoDB.Bson;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Topics.Models;
using Topics.Database;

namespace Topics.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> Logger;

		public HomeController(ILogger<HomeController> Logger)
		{
			this.Logger = Logger;
		}

		public IActionResult Index()
		{
			return View(new IndexViewModel());
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[IgnoreAntiforgeryToken]
		[ResponseCache(VaryByHeader = "User-Agent", Duration = 300, NoStore = false, Location = ResponseCacheLocation.Any)]
		public async Task<IActionResult> SignIn(string user, string pwd)
		{
			if (user == null) return View();
			Dictionary<string, string> data = (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pwd)) ? new Dictionary<string, string>
			{
				{"result", "invalid"}
			} : await Account.Login(user, pwd);

			switch (data["result"])
			{
				case "success":
					return View("Index", new IndexViewModel { LoggedIn = true, Username = user, Token = data["token"] });
				case "invalid": return View(new SignInViewModel("Invalid login"));
				case null:
				case "":
				default: return View(new SignInViewModel());
			}
		}
		public async Task<IActionResult> CreateAccount(string user, string pwd, string pwd_verify)
		{
			if (user == null) return View();
			if (pwd != pwd_verify) return View(new CreateAccountViewModel("Passwords do not match"));
			Dictionary<string, string> data = string.IsNullOrEmpty(user) ? new Dictionary<string, string>
			{
				{"result", "invalid"}
			} : await Account.Create(user, pwd);

			switch (data["result"])
			{
				default: return View();
				case "success": return Redirect("SignIn");
				case "invalid": return View(new CreateAccountViewModel(data["issue"]));
				case "taken": return View(new CreateAccountViewModel("Username is taken"));
				case null:
				case "": return View(new CreateAccountViewModel());
			}
		}
		public async Task<IActionResult> Profile(string user, string token, string requesting)
		{
			token = HttpUtility.UrlDecode(token);
			if (await Account.Exists(user ?? "-", token ?? "-"))
				return View(new ProfileViewModel
				{
					Username = user,
					ProfilePicture = await Account.GetProperty(user, "profile_picture")
				});
			return View(new ProfileViewModel
			{
				Username = "",
				ProfilePicture = ""
			});
		}

		[IgnoreAntiforgeryToken]
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}

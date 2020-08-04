using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MongoDB.Bson;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<IActionResult> SignIn(string user, string pwd)
        {
            string data = string.IsNullOrEmpty(user) ? "" : await AccountFinder.Find(user, pwd);
            Console.WriteLine(data);

            switch (data)
            {
                default: return View("Index");
                case "invalid": return View(new SignInViewModel("Invalid login"));
                case null:
                case "":  return View(new SignInViewModel());
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

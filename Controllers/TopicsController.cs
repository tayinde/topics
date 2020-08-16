using Microsoft.AspNetCore.Mvc;

namespace Topics.Controllers
{
	public class TopicsController : Controller
	{
		public IActionResult Discussions()
		{
			return View();
		}

		public IActionResult CreateTopic()
		{
			return View();
		}
	}
}
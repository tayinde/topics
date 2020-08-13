using Microsoft.AspNetCore.Mvc;

namespace Topics.Controllers
{
	public class TopicsController : Controller
	{
		public IActionResult Discussions()
		{
			return View();
		}
	}
}
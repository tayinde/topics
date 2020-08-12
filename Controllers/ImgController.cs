using System.Web;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Topics.Database;
using System.Collections.Generic;

namespace Topics.Controllers
{
	public class ImgController : Controller
	{	
		[HttpPost]
		public async Task<IActionResult> Upload(IFormFile file, string user, string token)
		{
			if (file != null && (file.FileName.EndsWith(".png") || file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".webp")))
				if (await Account.Exists(user, token))
				{
					string fileName = $"/images/{file.Name.CreateImageName()}.png";
					FileStream stream = System.IO.File.Create($"./wwwroot{fileName}");
					await file.CopyToAsync(stream);
					stream.Close();
					await Account.UpdateProperty(user, "profile_picture", fileName);
					Console.WriteLine("File uploaded.");
				}
			return RedirectToAction("Profile", "Home");
		}
	}
}
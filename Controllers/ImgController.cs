using System.Web;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
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
		public async Task<IActionResult> Upload(IFormFile file, string user, string token, string fileUpload, string url)
		{
			if (fileUpload == "true")
			{
				if (file != null && (file.FileName.EndsWith(".png") || file.FileName.EndsWith(".jpg") || file.FileName.EndsWith(".webp")) || file.FileName.EndsWith(".jpeg"))
					if (await Account.Exists(user, token))
					{
						string fileName = $"/images/{file.Name.CreateToken()}.png";
						FileStream stream = System.IO.File.Create($"./wwwroot{fileName}");
						await file.CopyToAsync(stream);
						stream.Close();
						await Account.UpdateProperty(user, "profile_picture", fileName);
						Console.WriteLine("File uploaded.");
					}
			} else
			{
				try
				{
					url = string.Join("", url.Split('?')[0]);
					if (!string.IsNullOrEmpty(url) && (url.EndsWith(".png") || url.EndsWith(".jpg") || url.EndsWith(".webp")) || url.EndsWith(".jpeg"))
						if (await Account.Exists(user, token))
						{
							await Account.UpdateProperty(user, "profile_picture", url);
						}
				} catch {}
			}
				return RedirectToAction("Profile", "Home");
			}
	}
}
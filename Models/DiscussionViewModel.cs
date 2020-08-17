using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Topics.Models
{
	public class DiscussionViewModel
	{
		public Dictionary<string, Dictionary<string, string>> topics { get; set; }
	}
}
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Topics.Models
{
	public class DiscussionViewModel
	{
		public List<Dictionary<string, string>> topics { get; set; }
	}
}
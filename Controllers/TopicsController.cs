using Microsoft.AspNetCore.Mvc;
using Topics.Models;
using System;
using System.Threading.Tasks;
using Topics.Database;
using MongoDB;

namespace Topics.Controllers
{
	public class TopicsController : Controller
	{
		public async Task<IActionResult> Discussions()
		{
			return View(new DiscussionViewModel { topics = await Database.Topics.GetAllTopics() });
		}

		public async Task<IActionResult> CreateTopic(string user, string token, string title, string keywords, string content)
		{
			if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(keywords) && !string.IsNullOrEmpty(content))
			{
				string topicId = user.CreateToken();
				await Database.Topics.CreateTopic(user, token, title, keywords, content, topicId);
				return Redirect($"/Topics/ViewTopic?topicId={topicId}#{user}");
			}
			else return View(new CreateTopicViewModel());
		}

		public async Task<IActionResult> ViewTopic(string topicId)
		{
			return View(new ViewTopicViewModel { TopicData = await Database.Topics.GetTopic(topicId), Comments = await Database.Topics.GetAllComments(topicId) });
		}
		public async Task<IActionResult> Comment(string user, string token, string topicId, string comment)
		{
			var date = DateTime.Now.ToString();
			try { await Database.Topics.AddComment(user, token, topicId, comment, date); } catch {}
			return Redirect($"/Topics/ViewTopic?topicId={topicId}#{user}");
		}
	}
}
using System.Collections.Generic;
using MongoDB.Bson;

namespace Topics.Models
{
	public class ViewTopicViewModel
	{
		#nullable enable
		public Dictionary<string, string>? TopicData { get; set; }
		public List<BsonDocument>? Comments { get; set; }
	}
}
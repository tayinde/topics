namespace Topics.Database
{
	public static partial class Topics
	{
		public static string ShortenContent(this string content)
		{
			return content.Length > 50 ? string.Join("", content.ToCharArray()[0..50]) + "..." : content;
		}
	}
}
namespace OpenNotifyAPI.Models
{
	public class PeopleInSpace
	{
		public ushort Number { get; set; }
		public string? Message { get; set; }
		public List<People>? People { get; set; }
	}
	public class People
	{
		public string? Name { get; set; }
		public string? Craft { get; set; }
	}
}

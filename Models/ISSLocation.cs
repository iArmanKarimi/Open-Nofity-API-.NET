namespace OpenNotifyAPI.Models
{
	public class Location
	{
		public string? Latitude { get; set; }
		public string? Longitude { get; set; }
	}
	public class ISSLocation
	{
		public string? Message { get; set; }
		public Location? Location { get; set; }
		public DateTimeOffset DateTime { get; set; }
	}
}

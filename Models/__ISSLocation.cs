namespace OpenNotifyAPI.Models
{
	public class __Location
	{
		public string? Latitude { get; set; }
		public string? Longitude { get; set; }
	}
	public class __ISSLocation
	{
		public int Timestamp { get; set; }
		public string? Message { get; set; }
		public __Location? ISS_position { get; set; }
	}
}

using OpenNotifyAPI.Models;
using System.Net.Http.Json;

namespace OpenNotifyAPI
{
	public static class OpenNotify
	{
		private static HttpClient httpClient = new HttpClient();
		private const string
			URL_PEOPLE = "http://api.open-notify.org/astros.json",
			URL_ISS_LOCATION = "http://api.open-notify.org/iss-now.json";

		/// <summary>
		/// Gets the current location of ISS (International Space Station)
		/// <example>
		/// <br/>
		/// Example:
		/// <code>
		/// var iss_loc = await OpenNotify.GetISSLocation();
		///	var output =
		///	 $"International Space Station Location:\n"
		///	 + $"DateTime: {iss_loc?.DateTime.ToLocalTime()}\n"
		///	 + $"Latitude: {iss_loc?.Location?.Latitude}\n"
		///	 + $"Longitude: {iss_loc?.Location?.Longitude}\n"
		///	;
		/// Console.Write(output);
		/// </code>
		/// </example>
		/// </summary>
		/// <exception cref="HttpRequestException"></exception>"
		public static async Task<ISSLocation?> GetISSLocation()
		{
			var _iss_loc = await httpClient.GetFromJsonAsync<__ISSLocation>(URL_ISS_LOCATION);
			if (_iss_loc == null) return null;
			return new ISSLocation
			{
				Message = _iss_loc.Message,
				Location = new Location
				{
					Latitude = _iss_loc.ISS_position?.Latitude,
					Longitude = _iss_loc.ISS_position?.Longitude
				},
				DateTime = DateTimeOffset
					.FromUnixTimeSeconds(Convert
					.ToInt64(_iss_loc?.Timestamp))
			};
		}

		/// <summary>
		/// Get the current number of people in space. It also returns the names and spacecraft those people are on.
		/// <example>
		/// <br/>
		/// Example:
		/// <code>
		/// var people_in_space = await OpenNotify.GetPeopleInSpace();
		///	Console.WriteLine($"There are {people_in_space?.Number} people in space right now.");
		///	var people = people_in_space
		///		?.People
		///		?.Select(p => $"Craft: {p.Craft}, Name: {p.Name}");
		///	Console.WriteLine("People who are in space:");
		///	Console.WriteLine(string.Join("\n", people));
		/// </code>
		/// </example>
		/// </summary>
		/// <exception cref="HttpRequestException"></exception>"
		public static async Task<PeopleInSpace?> GetPeopleInSpace() =>
			await httpClient.GetFromJsonAsync<PeopleInSpace>(URL_PEOPLE);

		public static void Dispose() => httpClient.Dispose();
	}
}

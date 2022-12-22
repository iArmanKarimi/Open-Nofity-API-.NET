using OpenNotifyAPI.Models;
using System.Net.Http.Json;

namespace OpenNotifyAPI
{
	public static class OpenNotify
	{
		public static async Task<ISSLocation> GetISSLocation()
		{
			throw new NotImplementedException();
		}
		private static HttpClient httpClient = new HttpClient();
		private const string
			URL_PEOPLE = "http://api.open-notify.org/astros.json",
			URL_ISS_LOCATION = "http://api.open-notify.org/iss-now.json";

		public static async Task<PeopleInSpace> GetPeopleInSpace()
		{
			throw new NotImplementedException();
		}
		public static void Dispose() => httpClient.Dispose();
	}
}

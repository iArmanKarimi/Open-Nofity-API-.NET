# Open Notify API - .NET

Open Nofity API client for `.NET` written in `C#`.

> Open Notify is an open source project to provide a simple programming interface for some of NASA’s awesome data.

For other languages, see [Open Notify API clients](https://github.com/iArmanKarimi/Open-Notify-API-clients)

## Installation

```bash

```

## Examples

Number of People in Space:

```cs
var people_in_space = await OpenNotify.GetPeopleInSpace();
Console.WriteLine($"There are {people_in_space?.Number} people in space right now.");
var people = people_in_space
 ?.People
 ?.Select(p => $"Craft: {p.Craft}, Name: {p.Name}");
Console.WriteLine("People who are in space:");
Console.WriteLine(string.Join("\n", people));
```

Current Location of the International Space Station:

```cs
var iss_loc = await OpenNotify.GetISSLocation();
var output =
  $"International Space Station's Location:\n"
  + $"DateTime: {iss_loc?.DateTime.ToLocalTime()}\n"
  + $"Latitude: {iss_loc?.Location?.Latitude}\n"
  + $"Longitude: {iss_loc?.Location?.Longitude}\n"
 ;
Console.Write(output);
```

## References

[Open Notify Website](http://open-notify.org/)

[Official API documentation](http://open-notify.org/Open-Notify-API/)

## License

[MIT](https://github.com/iArmanKarimi/Open-Nofity-API-.NET/blob/main/LICENSE)

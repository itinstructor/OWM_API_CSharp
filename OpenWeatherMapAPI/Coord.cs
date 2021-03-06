using GeoTimeZone;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;
using TimeZoneConverter;

namespace OpenWeatherMapAPI
{
	public class Coord
	{
		public double Latitude { get; }
		public double Longitude { get; }
		public string TimeZoneInfoIANA { get; }
		public DateTime LocationLocalDateTime { get; }

		public Coord(JToken coordData)
		{
			if (coordData is null)
				throw new System.ArgumentNullException(nameof(coordData));

			Longitude = double.Parse(coordData.SelectToken("lon").ToString(), CultureInfo.InvariantCulture);
			Latitude = double.Parse(coordData.SelectToken("lat").ToString(), CultureInfo.InvariantCulture);
			
			// Create DateTime object to hold location date and time
			// DateTime locationDateTime;
			// Get time zone from GeoTimezone nuget package
			TimeZoneInfoIANA = TimeZoneLookup.GetTimeZone(Latitude, Longitude).Result;

			// Convert Time Zone string info into Time Zone object TimeZoneConverter nuget package
			TimeZoneInfo tzInfo = TZConvert.GetTimeZoneInfo(TimeZoneInfoIANA);

			// Get location local time
			DateTimeOffset convertedTime = TimeZoneInfo.ConvertTime(DateTimeOffset.UtcNow, tzInfo);

			// Convert location time DateTimeOffset into DateTime object
			LocationLocalDateTime = convertedTime.DateTime;
		}
	}
}

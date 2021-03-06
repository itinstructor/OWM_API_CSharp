using Newtonsoft.Json.Linq;
using System.Globalization;

namespace OpenWeatherMapAPI
{
	public class Wind
	{
		// Wind direction data structure: Enumeration
		public enum DirectionEnum
		{
			North,
			North_North_East,
			North_East,
			East_North_East,
			East,
			East_South_East,
			South_East,
			South_South_East,
			South,
			South_South_West,
			South_West,
			West_South_West,
			West,
			West_North_West,
			North_West,
			North_North_West,
			Unknown
		}

		public double SpeedMetersPerSecond { get; }

		public double SpeedFeetPerSecond { get; }

		public double SpeedMilesPerHour { get; }

		//public DirectionEnum Direction { get; }

		public double Degree { get; }

		public double Gust { get; }

		public string DirectionLong { get; }
		public string DirectionShort { get; }

		public Wind(JToken windData)
		{
			if (windData is null)
				throw new System.ArgumentNullException(nameof(windData));

			// Wind Speed Raw OpenWeatherMap API meters per second
			SpeedMetersPerSecond = double.Parse(windData.SelectToken("speed").ToString(), CultureInfo.InvariantCulture);
			// Convert meters per second
			SpeedFeetPerSecond = SpeedMetersPerSecond * 3.28084;
			SpeedMilesPerHour = SpeedMetersPerSecond * 2.23694;

			Degree = double.Parse(windData.SelectToken("deg").ToString(), CultureInfo.InvariantCulture);
			// Return Direction enumeration based on degree
			// Direction = AssignDirection(Degree);
			// Return direction string based on direction enumeration
			DirectionLong = DirectionEnumToStringLong(AssignDirection(Degree));
			DirectionShort = DirectionEnumToStringShort(AssignDirection(Degree));
			if (windData.SelectToken("gust") != null)
				Gust = double.Parse(windData.SelectToken("gust").ToString(), CultureInfo.InvariantCulture);
		}

		// Return long direction string
		private static string DirectionEnumToStringLong(DirectionEnum dir)
		{
			switch (dir)
			{
				case DirectionEnum.North:
					return "North";
				case DirectionEnum.North_North_East:
					return "North North-East";
				case DirectionEnum.North_East:
					return "North East";
				case DirectionEnum.East_North_East:
					return "East North-East";
				case DirectionEnum.East:
					return "East";				
				case DirectionEnum.East_South_East:
					return "East South-East";
				case DirectionEnum.South_East:
					return "South East";
				case DirectionEnum.South_South_East:
					return "South South-East";
				case DirectionEnum.South:
					return "South";
				case DirectionEnum.South_South_West:
					return "South South-West";
				case DirectionEnum.South_West:
					return "South West";
				case DirectionEnum.West_South_West:
					return "West South-West";
				case DirectionEnum.West:
					return "West";
				case DirectionEnum.West_North_West:
					return "West North-West";
				case DirectionEnum.North_West:
					return "North West";
				case DirectionEnum.North_North_West:
					return "North North-West";
				case DirectionEnum.Unknown:
					return "Unknown";
				default:
					return "Unknown";
			}
		}

		// Return long direction string
		private static string DirectionEnumToStringShort(DirectionEnum dir)
		{
			switch (dir)
			{
				case DirectionEnum.North:
					return "N";
				case DirectionEnum.North_North_East:
					return "NNE";
				case DirectionEnum.North_East:
					return "NE";
				case DirectionEnum.East_North_East:
					return "ENE";
				case DirectionEnum.East:
					return "E";
				case DirectionEnum.East_South_East:
					return "ESE";
				case DirectionEnum.South_East:
					return "SE";
				case DirectionEnum.South_South_East:
					return "SSE";
				case DirectionEnum.South:
					return "S";
				case DirectionEnum.South_South_West:
					return "SSW";
				case DirectionEnum.South_West:
					return "SW";
				case DirectionEnum.West_South_West:
					return "WSW";
				case DirectionEnum.West:
					return "W";
				case DirectionEnum.West_North_West:
					return "WNW";
				case DirectionEnum.North_West:
					return "NW";
				case DirectionEnum.North_North_West:
					return "NNW";
				case DirectionEnum.Unknown:
					return "Unknown";
				default:
					return "Unknown";
			}
		}


		// Return direction enumeration based on degree
		private static DirectionEnum AssignDirection(double degree)
		{
			if (DegreeFallsBetween(degree, 348.75, 360))
				return DirectionEnum.North;
			if (DegreeFallsBetween(degree, 0, 11.25))
				return DirectionEnum.North;
			if (DegreeFallsBetween(degree, 11.25, 33.75))
				return DirectionEnum.North_North_East;
			if (DegreeFallsBetween(degree, 33.75, 56.25))
				return DirectionEnum.North_East;
			if (DegreeFallsBetween(degree, 56.25, 78.75))
				return DirectionEnum.East_North_East;
			if (DegreeFallsBetween(degree, 78.75, 101.25))
				return DirectionEnum.East;
			if (DegreeFallsBetween(degree, 101.25, 123.75))
				return DirectionEnum.East_South_East;
			if (DegreeFallsBetween(degree, 123.75, 146.25))
				return DirectionEnum.South_East;
			if (DegreeFallsBetween(degree, 146.25, 168.75))
				return DirectionEnum.South_South_East;
			if (DegreeFallsBetween(degree, 168.75, 191.25))
				return DirectionEnum.South;
			if (DegreeFallsBetween(degree, 191.25, 213.75))
				return DirectionEnum.South_South_West;
			if (DegreeFallsBetween(degree, 213.75, 236.25))
				return DirectionEnum.South_West;
			if (DegreeFallsBetween(degree, 236.25, 258.75))
				return DirectionEnum.West_South_West;
			if (DegreeFallsBetween(degree, 258.75, 281.25))
				return DirectionEnum.West;
			if (DegreeFallsBetween(degree, 281.25, 303.75))
				return DirectionEnum.West_North_West;
			if (DegreeFallsBetween(degree, 303.75, 326.25))
				return DirectionEnum.North_West;
			if (DegreeFallsBetween(degree, 326.25, 348.75))
				return DirectionEnum.North_North_West;
			return DirectionEnum.Unknown;
		}

		// Does the degree range fall within the min and max
		private static bool DegreeFallsBetween(double val, double min, double max)
		{
			if ((min <= val) && (val <= max))
				return true;
			return false;
		}
	}
}

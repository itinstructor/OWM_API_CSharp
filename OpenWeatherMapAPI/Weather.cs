using Newtonsoft.Json.Linq;
using System.Globalization;

namespace OpenWeatherMapAPI
{
	public class Weather
	{
		public int ID { get; }

		public string Main { get; }

		public string Description { get; }
		public string DescriptionTitleCase { get; }

		public string Icon { get; }

		public Weather(JToken weatherData)
		{
			if (weatherData is null)
				throw new System.ArgumentNullException(nameof(weatherData));

			ID = int.Parse(weatherData.SelectToken("id").ToString(), CultureInfo.InvariantCulture);
			Main = weatherData.SelectToken("main").ToString();
			Description = weatherData.SelectToken("description").ToString();
			DescriptionTitleCase = DescriptionToTitleCase(Description);
			Icon = weatherData.SelectToken("icon").ToString();
		}

		// Convert raw OpenWeatherMap API lower case Description to title case
		private static string DescriptionToTitleCase(string description)
        {
			// Create textinfo for Title Case conversaion
			TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
			// Convert description to title case
			description = textInfo.ToTitleCase(description);

			return description;
        }
	}
}

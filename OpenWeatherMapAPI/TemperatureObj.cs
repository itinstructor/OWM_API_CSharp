using System;

namespace OpenWeatherMapAPI
{
	public class TemperatureObj
	{
		public double CelsiusCurrent { get; }
		public double FahrenheitCurrent { get; }
		public double KelvinCurrent { get; }
		public double CelsiusMinimum { get; }
		public double FahrenheitMinimum { get; }
		public double KelvinMinimum { get; }
		public double CelsiusMaximum { get; }
		public double FahrenheitMaximum { get; }
		public double KelvinMaximum { get; }
		public double CelsiusFeelsLike { get; }
		public double KelvinFeelsLike { get; }
		public double FahrenheitFeelsLike { get; }
		public TemperatureObj(double temp, double min, double max, double feel)
		{
			KelvinCurrent = temp;
			KelvinMaximum = max;
			KelvinMinimum = min;
			KelvinFeelsLike = feel;

			CelsiusCurrent = convertToCelsius(KelvinCurrent);
			CelsiusMaximum = convertToCelsius(KelvinMaximum);
			CelsiusMinimum = convertToCelsius(KelvinMinimum);
			CelsiusFeelsLike = convertToCelsius(KelvinFeelsLike);

			FahrenheitCurrent = convertToFahrenheit(CelsiusCurrent);
			FahrenheitMaximum = convertToFahrenheit(CelsiusMaximum);
			FahrenheitMinimum = convertToFahrenheit(CelsiusMinimum);
			FahrenheitFeelsLike = convertToFahrenheit(CelsiusFeelsLike);
		}

		private static double convertToFahrenheit(double celsius)
		{
			return Math.Round(((9.0 / 5.0) * celsius) + 32, 3);
		}

		private static double convertToCelsius(double kelvin)
		{
			return Math.Round(kelvin - 273.15, 3);
		}
	}
}

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

			CelsiusCurrent = ConvertToCelsius(KelvinCurrent);
			CelsiusMaximum = ConvertToCelsius(KelvinMaximum);
			CelsiusMinimum = ConvertToCelsius(KelvinMinimum);
			CelsiusFeelsLike = ConvertToCelsius(KelvinFeelsLike);

			FahrenheitCurrent = ConvertToFahrenheit(KelvinCurrent);
			FahrenheitMaximum = ConvertToFahrenheit(KelvinMaximum);
			FahrenheitMinimum = ConvertToFahrenheit(KelvinMinimum);
			FahrenheitFeelsLike = ConvertToFahrenheit(KelvinFeelsLike);
		}

		private static double ConvertToFahrenheit(double kelvin)
		{
			return Math.Round(((kelvin - 273.15) * 1.8) + 32) ;
		}

		private static double ConvertToCelsius(double kelvin)
		{
			return Math.Round(kelvin - 273.15, 3);
		}
	}
}

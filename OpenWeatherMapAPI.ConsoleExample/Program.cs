using System;

namespace OpenWeatherMapAPIConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an http client to GET the current weather data from OpenWeatherMapAPI
            var client = new OpenWeatherMapAPI.API("Your API Key");
            
            Console.WriteLine("OpenWeatherMapAPI Console Example Application\n");

            Console.WriteLine("Enter city to get weather data for:");
            var city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Fetching weather data for '{city}'");
            
            // GET http data from OpenWeatherMapAPI Query method
            var results = client.Query(city,"q");

            // Current weather is displayed as properties of results query object
            Console.WriteLine($"\nCurrent weather in {city}");
            Console.WriteLine($"Temperature: {results.Main.Temperature.FahrenheitCurrent.ToString("n2")} °F");
            Console.WriteLine($"Description: {results.Weathers[0].DescriptionTitleCase}");
            Console.WriteLine($"Wind: {results.Wind.SpeedMilesPerHour.ToString("n2")} mph");
            Console.WriteLine($"Direction: {results.Wind.DirectionLong}");

            Console.ReadLine();
        }
    }
}

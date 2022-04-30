using System;

namespace OpenWeatherMapAPIConsoleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an http client to GET the current weather data from OpenWeatherMapAPI
            var client = new OpenWeatherMapAPI.API("Your OpenWeatherMap API Key Here");

            Console.WriteLine("OpenWeatherMapAPI Console Example Application\n");
            // Prompt the user for input
            Console.Write("Enter city: ");
            // Read text input from console
            var city = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Fetching weather data for '{city}'");

            // GET http data from OpenWeatherMapAPI Query method
            var results = client.Query(city, "q");

            // Current weather is displayed as properties of results query object
            Console.WriteLine($"\nCurrent weather in {city}");
            Console.WriteLine($"Temperature: {results.Main.Temperature.FahrenheitCurrent.ToString("n1")}°F");
            Console.WriteLine($"Description: {results.Weathers[0].DescriptionTitleCase}");
            Console.WriteLine($"Wind: {results.Wind.SpeedMilesPerHour.ToString("n1")}mph { results.Wind.DirectionLong}");
            
            // Pause at the end to allow weather display
            Console.ReadLine();
        }
    }
}

/**
* Project:       OpenWeatherMapAPI - C# Class Library
* Programmer:    itinstructor
* Creation Date: 01/10/2021
* Last Revision: 
* Description:   C# Class library to set OpenWeatherMap API into C# properties
 */

using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace OpenWeatherMapAPI
{
    public class Query
    {
        public bool ValidRequest { get; }
        public Coord Coord { get; }
        
        // Returned as a list
        public List<Weather> Weathers { get; } = new List<Weather>();
        public string Base { get; }
        public Main Main { get; }
        public double Visibility { get; }
        public double VisibilityKm { get; }
        public double VisibilityMiles { get; }
        public Wind Wind { get; }
        public Rain Rain { get; }
        public Snow Snow { get; }
        public Clouds Clouds { get; }
        public Sys Sys { get; }
        public int ID { get; }
        public string Name { get; }
        public int Cod { get; }
        public int TimeZone { get; }
        
        public Query(string apiKey, string queryStr, string queryCode)
        {
            // Method to determine the query code passed in: q, zip, or id
            // Comes back q by default
            string queryType = QueryType(queryCode);
            
            // Create a jsonData object to store the data returned from OpenWeatherMap API call
            JObject jsonData;

            // Create an http client to retreive data
            using (var client = new System.Net.WebClient())
            {
                // Use the http client to retrieve OpenWeatherMap API call, store the data in the jsonData objec
                jsonData = JObject.Parse(client.DownloadString($"http://api.openweathermap.org/data/2.5/weather?appid={apiKey}&{queryType}={queryStr}"));
            }
            // Test for data validity from the return code 200
            if (jsonData.SelectToken("cod").ToString() == "200")
            {
                ValidRequest = true;
                
                // Latitude and Longitude
                Coord = new Coord(jsonData.SelectToken("coord"));
                foreach (JToken weather in jsonData.SelectToken("weather"))
                  Weathers.Add(new Weather(weather));
                Base = jsonData.SelectToken("base").ToString();
                Main = new Main(jsonData.SelectToken("main"));
                // Visibility in meters
                if (jsonData.SelectToken("visibility") != null)
                {
                    Visibility = double.Parse(jsonData.SelectToken("visibility").ToString(), CultureInfo.InvariantCulture);
                    VisibilityKm = Visibility * .001;
                    VisibilityMiles = Visibility * 0.000621371;
                }
                Wind = new Wind(jsonData.SelectToken("wind"));
                if (jsonData.SelectToken("rain") != null)
                    Rain = new Rain(jsonData.SelectToken("rain"));
                if (jsonData.SelectToken("snow") != null)
                    Snow = new Snow(jsonData.SelectToken("snow"));
                Clouds = new Clouds(jsonData.SelectToken("clouds"));
                Sys = new Sys(jsonData.SelectToken("sys"));
                
                // Shift in seconds from UTC
                TimeZone = int.Parse(jsonData.SelectToken("timezone").ToString());
                
                // Unique OpenWeatherMap City ID
                ID = int.Parse(jsonData.SelectToken("id").ToString(), CultureInfo.InvariantCulture);
                
                // City Name
                Name = jsonData.SelectToken("name").ToString();
                Cod = int.Parse(jsonData.SelectToken("cod").ToString(), CultureInfo.InvariantCulture);
            }
            else
            {
                ValidRequest = false;
            }
        }

        // Determine and return the Query Code
        private static string QueryType(string qryCode)
        {
            // Set the default query code
            string queryCode = "q";
            
            // Determine type of OpenWeatherMap query
            // City or City, Country Code or City, State Code, Country Code
            if (qryCode == "q")
            {
                queryCode = "q";
            }
            // Zip Code
            else if (qryCode == "zip")
            {
                queryCode = "zip";
            }
            // OpenWeatherMap unique City ID
            else if (qryCode == "id")
            {
                queryCode = "id";
            }
            return queryCode;
        }
    }
}
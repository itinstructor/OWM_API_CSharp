# OpenWeatherMap-API - C# Class Library

## Overview
- This library retrieves the OpenWeatherMap API returns in JSON.
- This library converts the incoming JSON to C# objects with properties for easy interaction in C# projects. 
- It supports (most/all) of the returned data the API returns in JSON.
- There are extra conversions not in the API.
- The JSON API returned properties are sometimes present, and sometimes not.
- Use exception handling in an application. Things go wrong.
- Built in .NET Standard 2.0

## Returned Data From OpenWeatherMap API
### Clouds
  * All - Returns raw OpenWeatherMap API percentage of cloud cover (double)
### Coord
  * Longitude - Returns raw OpenWeatherMap API query location longitude (double)
  * Latitude - Returns raw OpenWeatherMap API query location latitude (double)
  * LocationLocalDateTime - Returns query location Date and Time from longitude and latitude (DateTime)
  * TimeZoneInfoIANA - Returns IANA Time Zone Information from longitude and latitude (America/Denver) (string)
  * ID - Returns raw OpenWeatherMap API unique city identification (int)
### Main
  * CelsiusCurrent - Returns converted Kelvin values of current temperature in Centigrade (double)
  * FahrenheitCurrent - Returns converted Kelvin values of current temperature in Fahrenheit (double)
  * KelvinCurrent - Returns raw OpenWeatherMap API values for temperature in Kelvin (double)
  * CelsiusMinimum - Returns converted Kelvin values of minimum temperature observed now in Centigrade within large megalopolises and urban areas (double)
  * FahrenheitMinimum - Returns converted Kelvin values of minimum temperature observed now in Fahrenheit within large megalopolises and urban areas (double)
  * KelvinMinimum - Returns raw OpenWeatherMap API values for minimum temperature observed now in Kelvin within large megalopolises and urban areas (double)
  * CelsiusMaximum - Returns converted Kelvin values of maximum temperature observed now in Centigrade within large megalopolises and urban areas (double)
  * FahrenheitMaximum - Returns converted Kelvin values of maximum temperature observed now in Fahrenheit within large megalopolises and urban areas (double)
  * KelvinMaximum - Returns raw OpenWeatherMap API feels_like values for maximum temperatures now in Kelvin within large megalopolises and urban areas (double)
  * CelsiusFeelsLike – Returns converted Kelvin values of human perception of weather in Celsius (double)
  * FahrenheitFeelsLike - Returns converted Kelvin values of human perception of weather in Fahrenheit (double)
  * KelvinFeelsLike – Returns raw OpenWeatherMap API values of human perception of weather in Kelvin (double)
  * SeaLevel - Returns raw OpenWeatherMap API values for atmospheric pressure on sea level, hPa (double)
  * GroundLevel - Returns raw OpenWeatherMap API values for atmospheric pressure on ground level, hPa (double)
  * Pressure – Returns raw OpenWeatherMap API values for atmospheric pressure, hPa (double)
  * PressureInchesOfMercury – Returns converted atmospheric pressure values from Pressure, inHg (double)
  * Humidity - Returns percent humidity (double)
  * Name - Returns raw OpenWeatherMap API City Name (string)
  * Rain
    * 3h - Returns raw OpenWeatherMap API rain related data for the last 3 hours at query location (if available) (double)
### Snow
  * 3h - Returns raw OpenWeatherMap API snow related data for the last 3 hours at query location (if available) (double)
### Sys
  * Type - System related parameter, do not use
  * ID - Returns raw OpenWeatherMap API unique city identification (int)
  * Message - System related parameter, avoid usage
  * Country - Returns raw OpenWeatherMap API Country code of given query location  (string)
  * Sunrise - Returns DateTime for sunrise converted from OpenWeatherMap API returned unix time (DateTime)
  * Sunset - Returns DateTime for sunset converted from OpenWeatherMap API returned unix time (DateTime)
  * TimeZone - Returns raw OpenWeatherMap API timezone shift in seconds from UTC (int)
  * Visibility - Returns raw OpenWeatherMap API visibility in kilometers (double)
  * VisibilityKm - Returns converted visibility in kilometers (double)
  * VisibilityMiles - Returns converted visibility in miles (double)
### Weather
  
  NOTE: The Weather section returns as a list. Use this syntax to retrieve the values: Weathers[0].parameter

  * ID - System related parameter, avoid usage
  * Main - Returns raw OpenWeatherMap API short weather description (IE rain, snow, etc.) (string)
  * Description - Returns raw OpenWeatherMap API detailed weather description (heavy intensity rain, etc.) (string)
  * DescriptionTitleCase - Returns converted Description in Title Case (Heavy Intensity Rain, etc.) (string)
  * Icon - Returns raw OpenWeatherMap API Weather icon ID (string)
  
    Base url to build the query string for the weather icon

    ```
    private const string iconUrl = "http://openweathermap.org/img/wn/";
    ```
  
     Display the icon

    ```
    pctWeatherIcon.ImageLocation = iconUrl + results.Weathers[0].Icon + "@2x.png";
    ```
### Wind
  * SpeedMetersPerSecond - Returns raw OpenWeatherMap API wind speed in meters per second (double)
  * SpeedFeetPerSecond - Returns wind speed in converted values in feet per second (double)
  * SpeedMilesPerHour - Returns wind speed in converted values in miles per hour (double)
  * DirectionLong - Returns long direction string of wind on basis of degree, North North-East (string)
  * DirectionShort - Returns short direction string of wind on basis of degree, NNE (string)
  * Degree - Returns raw OpenWeatherMap API 360-oriented degree (double)
  * Gust - Returns raw OpenWeatherMap API speed of wind gusts in meters per second (double)

## Installing OpenWeatherMapAPI.dll
There are two methods of obtaining the OpenWeatherMapAPI.dll.
### Easy Way
1. Download the OpenWeatherMap.dll file. Copy it to your Visual C# project.
2. In your project that's using this code, reference the built DLL from the previous step:
   - Project dropdown -> Add Reference -> Search for the created DLL file.
   - Generally, the path is something like: `/OpenWeatherMap-API-CSharp/OpenWeatherAPI.dll`
### Hard Way - Build Your Own OpenWeatherMap.dll
1. Clone this code with the GitHub desktop
2. Open the project in Visual Studio
3. Build the project
4. In the project that's using this code, reference or copy the built DLL to your project from the previous step:
   - Project menu -> Add Reference -> Search for the created DLL(s) file.
   - Generally, the path is something like: `/OpenWeatherMap-API-CSharp/bin/Debug/OpenWeatherMapAPI.dll`

## Example Console Usage
```csharp
var client = new OpenWeatherMapAPI.API("Your Personal OpenWeatherMap API Key");
var results = client.Query(city,"q");
Console.WriteLine($"\n\nThe temperature in {city} is {results.Main.Temperature.FahrenheitCurrent}°F. \nThere is a {results.Wind.SpeedMilesPerHour.ToString("n2")} mph wind from the {results.Wind.DirectionStringShort}");
```

## Sample Project
This repository contains two example projects.
- Console Example
- GUI Example

## Credits and Libraries Utilized
- Newtonsoft.Json - JSON parsing class
- GeoTimeZone - Provides an IANA time zone identifier from latitude and longitude coordinates
- TimeZoneConverter - Lightweight library to convert quickly between IANA, Windows, and Rails time zone names

## Purpose
I am an Information Technology Instructor at Western Nebraska Community College. I teach Information Technology Technical Support, CyberSecurity and Computer Science.
This library was forked and modified for a Visual C# introductory programming class as a tutorial. Students are given the opportunity to learn how to consume a public API without the underlying complexity of parsing json or xml. It reinforces OOP concepts of objects and properties, while being a fun and interesting project.

### Changes
- 01/31/2021: Added LocationLocalTime based on Longitude and Latitude, Added Visibility, VisibilityKm, and VisibilityMiles
- 01/23/2021: Added missing AssignDirection degree conversion South_South_East, added Wind properties DirectionLong: North North-East, DirectionShort: NNE, Added Weather converted property DescriptionTitleCase (Windy, Intense Rain) converts from raw API Description which is lower case
- 01/17/2021: Added the ability to set the type of query: q (City Name), zip, or ID (City) by passing a queryType parameter, added SpeedMilesPerHour and PressureInchesOfMercury property
- 01/17/2021: Forked project from swiftyspiffy, initial commit

### License
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.

Copyright (c) 2021 William A Loring

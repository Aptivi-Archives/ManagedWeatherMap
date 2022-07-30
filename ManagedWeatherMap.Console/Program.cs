/*
 * MIT License
 *
 * Copyright (c) 2021 Aptivi
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 * 
 */

using System;
using ManagedWeatherMap.Core;

namespace ManagedWeatherMap.ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ApiKey;
            string StringID;
            ForecastInfo forecastInfo;
            bool IsNumeric;

            // ID or name
            Console.Write("Enter city ID or name: ");
            StringID = Console.ReadLine();
            IsNumeric = long.TryParse(StringID, out long FinalID);

            // API key
            Console.Write("Enter API key: ");
            ApiKey = Console.ReadLine();

            // Get weather info
            if (IsNumeric)
            {
                forecastInfo = Forecast.GetWeatherInfo(FinalID, ApiKey, UnitMeasurement.Metric);
            }
            else
            {
                forecastInfo = Forecast.GetWeatherInfo(StringID, ApiKey, UnitMeasurement.Metric);
            }
            
            // Print the weather information
            Console.WriteLine("City ID: " + forecastInfo.CityID);
            Console.WriteLine("City Name: " + forecastInfo.CityName);
            Console.WriteLine("Weather State: " + forecastInfo.Weather);
            Console.WriteLine("Temperature: " + forecastInfo.Temperature);
            Console.WriteLine("Feels Like: " + forecastInfo.FeelsLike);
            Console.WriteLine("Pressure: " + forecastInfo.Pressure);
            Console.WriteLine("Humidity: " + forecastInfo.Humidity);
            Console.WriteLine("Wind Speed: " + forecastInfo.WindSpeed);
            Console.WriteLine("Wind Direction: " + forecastInfo.WindDirection);
        }
    }
}

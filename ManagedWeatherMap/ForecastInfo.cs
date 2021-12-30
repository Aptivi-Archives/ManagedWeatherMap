/*
 * MIT License
 *
 * Copyright (c) 2021 EoflaOE and its companies
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

namespace Core
{
    /// <summary>
    /// Forecast information
    /// </summary>
    public partial class ForecastInfo
    {
        /// <summary>
        /// City ID
        /// </summary>
        public long CityID { get; set; }
        /// <summary>
        /// City Name
        /// </summary>
        public string CityName { get; set; }
        /// <summary>
        /// Weather condition
        /// </summary>
        public WeatherCondition Weather { get; set; }
        /// <summary>
        /// Temperature measurement
        /// </summary>
        public UnitMeasurement TemperatureMeasurement { get; set; }
        /// <summary>
        /// Temperature
        /// </summary>
        public double Temperature { get; set; }
        /// <summary>
        /// Feels like
        /// </summary>
        public double FeelsLike { get; set; }
        /// <summary>
        /// Pressure in hPa
        /// </summary>
        public double Pressure { get; set; }
        /// <summary>
        /// Humidity in percent
        /// </summary>
        public double Humidity { get; set; }
        /// <summary>
        /// Wind speed. Imperial: mph, Metric/Kelvin: m.s
        /// </summary>
        public double WindSpeed { get; set; }
        /// <summary>
        /// Wind direction in degrees
        /// </summary>
        public double WindDirection { get; set; }
    }

    /// <summary>
    /// Unit measurement
    /// </summary>
    public enum UnitMeasurement
    {
        /// <summary>
        /// Default unit measurement for OWM
        /// </summary>
        Kelvin = 1,
        /// <summary>
        /// Metric units (Celsius)
        /// </summary>
        Metric,
        /// <summary>
        /// Imperial units (Fahrenheit)
        /// </summary>
        Imperial
    }

    /// <summary>
    /// Weather condition
    /// </summary>
    public enum WeatherCondition
    {
        // Thunderstorms
        /// <summary>
        /// Thunderstorm with light rain
        /// </summary>
        ThunderstormLightRain = 200,
        /// <summary>
        /// Thunderstorm with rain
        /// </summary>
        ThunderstormRain,
        /// <summary>
        /// Thunderstorm with heavy rain
        /// </summary>
        ThunderstormHeavyRain,
        /// <summary>
        /// Light thunderstorm
        /// </summary>
        LightThunderstorm = 210,
        /// <summary>
        /// Thunderstorm
        /// </summary>
        Thunderstorm,
        /// <summary>
        /// Heavy thunderstorm
        /// </summary>
        HeavyThunderstorm,
        /// <summary>
        /// Ragged thunderstorm
        /// </summary>
        RaggedThunderstorm = 221,
        /// <summary>
        /// Thunderstorm with light drizzle
        /// </summary>
        ThunderstormLightDrizzle = 230,
        /// <summary>
        /// Thunderstorm with drizzle
        /// </summary>
        ThunderstormDrizzle = 231,
        /// <summary>
        /// Thunderstorm with heavy drizzle
        /// </summary>
        ThunderstormHeavyDrizzle = 232,

        // Drizzles
        /// <summary>
        /// Light intensity drizzle
        /// </summary>
        LightDrizzle = 300,
        /// <summary>
        /// Drizzle
        /// </summary>
        Drizzle,
        /// <summary>
        /// Heavy intensity drizzle
        /// </summary>
        HeavyDrizzle,
        /// <summary>
        /// Light intensity drizzle rain
        /// </summary>
        LightDrizzleRain = 310,
        /// <summary>
        /// Drizzle rain
        /// </summary>
        DrizzleRain,
        /// <summary>
        /// Heavy intensity drizzle rain
        /// </summary>
        HeavyDrizzleRain,
        /// <summary>
        /// Shower rain and drizzle
        /// </summary>
        DrizzleShowerRain,
        /// <summary>
        /// Heavy shower rain and drizzle
        /// </summary>
        DrizzleHeavyShowerRain,
        /// <summary>
        /// Shower drizzle
        /// </summary>
        ShowerDrizzle = 321,

        // Rains
        /// <summary>
        /// Light rain
        /// </summary>
        LightRain = 500,
        /// <summary>
        /// Moderate rain
        /// </summary>
        ModerateRain,
        /// <summary>
        /// Heavy rain
        /// </summary>
        HeavyRain,
        /// <summary>
        /// Very heavy rain
        /// </summary>
        VeryHeavyRain,
        /// <summary>
        /// Extreme rain
        /// </summary>
        ExtremeRain,
        /// <summary>
        /// Freezing rain
        /// </summary>
        FreezingRain = 511,
        /// <summary>
        /// Light shower rain
        /// </summary>
        LightShowerRain = 520,
        /// <summary>
        /// Shower rain
        /// </summary>
        ShowerRain,
        /// <summary>
        /// Heavy shower rain
        /// </summary>
        HeavyShowerRain,
        /// <summary>
        /// Ragged shower rain
        /// </summary>
        RaggedShowerRain = 531,

        // Snows
        /// <summary>
        /// Light snow
        /// </summary>
        LightSnow = 600,
        /// <summary>
        /// Snow
        /// </summary>
        Snow,
        /// <summary>
        /// Heavy snow
        /// </summary>
        HeavySnow,
        /// <summary>
        /// Sleet
        /// </summary>
        Sleet = 611,
        /// <summary>
        /// Light shower sleet
        /// </summary>
        LightShowerSleet,
        /// <summary>
        /// Shower sleet
        /// </summary>
        ShowerSleet,
        /// <summary>
        /// Light rain and snow
        /// </summary>
        LightRainAndSnow = 615,
        /// <summary>
        /// Rain and snow
        /// </summary>
        RainAndSnow,
        /// <summary>
        /// Light shower snow
        /// </summary>
        LightShowerSnow = 620,
        /// <summary>
        /// Shower snow
        /// </summary>
        ShowerSnow,
        /// <summary>
        /// Heavy shower snow
        /// </summary>
        HeavyShowerSnow,

        // Atmosphere
        /// <summary>
        /// Misty weather
        /// </summary>
        Mist = 701,
        /// <summary>
        /// Smoky weather
        /// </summary>
        Smoke = 711,
        /// <summary>
        /// Hazy weather
        /// </summary>
        Haze = 721,
        /// <summary>
        /// Sand or dust whirls
        /// </summary>
        DustWhirls = 731,
        /// <summary>
        /// Foggy weather
        /// </summary>
        Fog = 741,
        /// <summary>
        /// Sandy weather
        /// </summary>
        Sand = 751,
        /// <summary>
        /// Dusty weather
        /// </summary>
        Dust = 761,
        /// <summary>
        /// Volcanic ash
        /// </summary>
        Ash,
        /// <summary>
        /// Squall
        /// </summary>
        Squall = 771,
        /// <summary>
        /// Tornado
        /// </summary>
        Tornado = 781,

        // Clear and Clouds
        /// <summary>
        /// Clear sky (free of clouds)
        /// </summary>
        Clear = 800,
        /// <summary>
        /// Few clouds (11-25%)
        /// </summary>
        FewClouds,
        /// <summary>
        /// Partly cloudy (Scattered, 25-50%)
        /// </summary>
        PartlyCloudy,
        /// <summary>
        /// Broken Clouds (51-84%)
        /// </summary>
        BrokenClouds,
        /// <summary>
        /// Mostly Cloudy (Overcast, 85-100%)
        /// </summary>
        MostlyCloudy
    }
}

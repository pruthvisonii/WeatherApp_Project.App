using System;

namespace WeatherApp_Project.Models
{
    /// <summary>
    /// Represents weather data for a specific location.
    /// </summary>
    public class WeatherData
    {
        /// <summary>
        /// The temperature in degrees Celsius.
        /// </summary>
        public double Temperature { get; set; }

        /// <summary>
        /// The humidity percentage.
        /// </summary>
        public double Humidity { get; set; }

        /// <summary>
        /// The wind speed in kilometers per hour.
        /// </summary>
        public double WindSpeed { get; set; }

        /// <summary>
        /// The amount of precipitation in millimeters.
        /// </summary>
        public double Precipitation { get; set; }

        /// <summary>
        /// The date and time when the weather data was recorded.
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}

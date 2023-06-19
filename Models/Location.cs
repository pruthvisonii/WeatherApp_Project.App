namespace WeatherApp_Project.Models
{
    /// <summary>
    /// Represents a location for which weather data can be retrieved.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The name of the location (e.g., city, town, or landmark).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The latitude coordinate of the location.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// The longitude coordinate of the location.
        /// </summary>
        public double Longitude { get; set; }
    }
}

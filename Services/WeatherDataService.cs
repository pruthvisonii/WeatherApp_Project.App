using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WeatherApp_Project.Models;

namespace WeatherApp_Project.Services
{
    public class WeatherDataService
    {
        private const string ApiKey = "e0d1f860126c143dab0ab18ae2087118\r\n"; // Replace with your actual API key

        public async Task<WeatherData> GetWeatherDataAsync(string location)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    // Send a GET request to the weather data API
                    string apiUrl = $"https://api.weatherapi.com/v1/current.json?key={ApiKey}&q={location}&aqi=no";
                    var response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string json = await response.Content.ReadAsStringAsync();

                        // Deserialize the JSON response to a WeatherData object
                        var weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                        return weatherData;
                    }
                    else
                    {
                        // Handle the case when the API request is not successful
                        Console.WriteLine($"API request failed with status code {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occurred during the API request
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            // Return null if the weather data couldn't be retrieved
            return null;
        }
    }
}

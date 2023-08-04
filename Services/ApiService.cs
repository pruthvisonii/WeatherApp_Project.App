using System;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp_Project.Models;

namespace WeatherApp_Project.Services
{
    public static class ApiService
    {
        private const string ApiKey = "e0d1f860126c143dab0ab18ae2087118";
        private static readonly HttpClient httpClient = new HttpClient();

        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&units=metric&appid={ApiKey}";
            var response = await httpClient.GetStringAsync(apiUrl);
            return System.Text.Json.JsonSerializer.Deserialize<Root>(response);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var apiUrl = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&units=metric&appid={ApiKey}";
            var response = await httpClient.GetStringAsync(apiUrl);
            return System.Text.Json.JsonSerializer.Deserialize<Root>(response);
        }
    }
}

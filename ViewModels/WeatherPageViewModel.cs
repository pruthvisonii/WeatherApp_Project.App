using Microsoft.Maui.Controls;

namespace WeatherApp_Project.ViewModels
{
    public class WeatherPageViewModel : BindableObject
    {
        private string _weatherData;

        public string WeatherData
        {
            get => _weatherData;
            set
            {
                _weatherData = value;
                OnPropertyChanged();
            }
        }

        public WeatherPageViewModel()
        {
            // Fetch weather data and assign it to the WeatherData property
            WeatherData = "Today's weather: Sunny";
        }
    }
}


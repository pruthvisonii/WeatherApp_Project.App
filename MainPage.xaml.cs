using Microsoft.Maui.Controls;

namespace WeatherApp_Project.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPage();
        }
    }
}

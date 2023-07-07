using WeatherApp_Project.Views;

namespace WeatherApp_Project;

public partial class WelcomePage : ContentPage
{
	public WelcomePage()
	{
        InitializeComponent();
	}

    private void BtnGetStarted_Clicked(object sender, EventArgs e)
    {
		Navigation.PushModalAsync(new MainPage());
    }
}
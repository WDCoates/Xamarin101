using System;
using Xamarin.Forms;

namespace T12_WebService
{
    public partial class MainPage : ContentPage
    {
        private RestService _restService;
        public MainPage()
        {
            InitializeComponent();
            _restService = new RestService();
            BindingContext = this;
        }

        private async void GetWeather_Clicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cityEntry.Text))
            {
                WeatherData weatherData =
                    await _restService.GetWeatherDataAsync(GenerateRequestUri(Constants.OpenWeatherMapEndpoint));
            }

        }

        private string GenerateRequestUri(string endPoint)
        {
            string requestUri = endPoint;
            requestUri += $"?q={cityEntry.Text}";
            requestUri += "&units=metric"; // units=metric  or  imperial
            requestUri += $"&APPID={Constants.OpenWeatherMapApiKey}";
            return requestUri;
        }
    }
}

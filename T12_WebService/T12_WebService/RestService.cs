using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace T12_WebService
{
    public class RestService
    {
        HttpClient _httpClient;

        public RestService()
        {
            _httpClient = new HttpClient();
        }


        public async Task<WeatherData> GetWeatherDataAsync(string uri)
        {
            WeatherData weatherData = null;
            try
            {
                HttpResponseMessage resp = await _httpClient.GetAsync(uri);
                if (resp.IsSuccessStatusCode)
                {
                    string content = await resp.Content.ReadAsStringAsync();
                    weatherData = JsonConvert.DeserializeObject<WeatherData>(content);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine($"\tError {e.Message}");

            }

            return weatherData;
        }
    }
}

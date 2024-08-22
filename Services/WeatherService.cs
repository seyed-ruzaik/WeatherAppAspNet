
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.Models;
using Newtonsoft.Json;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public WeatherService(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient;
            _apiKey = apiKey;
        }

        public async Task<WeatherViewModel> GetWeatherAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={_apiKey}";
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();
            var weatherResponse = JsonConvert.DeserializeObject<OpenWeatherResponse>(content);

            return new WeatherViewModel
            {
                City = weatherResponse.Name,
                Temperature = weatherResponse.Main.Temp,
                FeelsLike = weatherResponse.Main.Feels_Like,
                Description = weatherResponse.Weather[0].Description
            };
        }
    }
}

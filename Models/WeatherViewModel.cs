
namespace WeatherApp.Models
{
    public class WeatherViewModel
    {
        public string City { get; set; }
        public double Temperature { get; set; }
        public double FeelsLike { get; set; }
        public string Description { get; set; }
    }
}

// Models/OpenWeatherResponse.cs
namespace WeatherApp.Models
{
    public class OpenWeatherResponse
    {
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
        public string Name { get; set; }
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
    }

    public class Weather
    {
        public string Description { get; set; }
    }
}

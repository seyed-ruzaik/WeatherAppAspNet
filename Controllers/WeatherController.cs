
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WeatherApp.Services;

namespace WeatherApp.Controllers
{
    public class WeatherController : Controller
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                ViewBag.Error = "Please enter a city name.";
                return View();
            }

            var weather = await _weatherService.GetWeatherAsync(city);

            if (weather == null)
            {
                ViewBag.Error = "Unable to retrieve weather data.";
                return View();
            }

            return View(weather);
        }
    }
}

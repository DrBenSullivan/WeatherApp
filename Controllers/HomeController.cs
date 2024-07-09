using WeatherApp.Models;
using WeatherApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            List<CityWeather> cityWeatherList = DataService.GetCityWeatherList();
            ViewData["Title"] = "Weather";
            return View(cityWeatherList);
        }

        [Route("weather/{cityCode}")]
        public IActionResult Weather(string cityCode)
        {
            CityWeather? model = DataService.GetCityWeatherList()
                .Where(c => c.CityUniqueCode == cityCode.ToUpper())
                .FirstOrDefault();

            if (model != null)
            {
                ViewData["Title"] = "Weather";
                return View(model);
            }
            else
            {
                ViewData["Title"] = "Error 404:";
                ViewData["Error"] = $"There is no city with Unique City Code: {cityCode.ToUpper()}";
				return View("Error");
			}
        }
    }
}

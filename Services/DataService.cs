using WeatherApp.Models;

namespace WeatherApp.Services
{
	public class DataService
	{
		// Service purely to return hard-coded data as per brief.
		private static readonly List<CityWeather> _cityWeatherList = new List<CityWeather>()
		{
			new CityWeather() {
				CityUniqueCode = "LDN",
				CityName = "London",
				DateAndTime = DateTime.Parse("2030-01-01 8:00"),
				TemperatureFahrenheit = 33
			},
			new CityWeather() {
				CityUniqueCode = "NYC",
				CityName = "New York",
				DateAndTime = DateTime.Parse("2030-01-01 3:00"),
				TemperatureFahrenheit = 60
			},
			new CityWeather() {
				CityUniqueCode = "PAR",
				CityName = "Paris",
				DateAndTime = DateTime.Parse("2030-01-01 9:00"),
				TemperatureFahrenheit = 82
			}
		};

		public static List<CityWeather> GetCityWeatherList() => _cityWeatherList;
		
	}
}

namespace WeatherForecastWebApi.Controllers
{
    using System.Web.Http;
    using WeatherForecastWebApi.Services;
    using WeatherForecastWebApi.ViewModel;

    public class WeatherController : ApiController
    {
        private readonly IWeatherService weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        [HttpGet]
        [Route("api/weather/{country}/{city}")]
        public WeatherViewModel Weather(string country, string city)
        {
            return this.weatherService.GetWeatherViewModel(country, city);
        }
    }
}

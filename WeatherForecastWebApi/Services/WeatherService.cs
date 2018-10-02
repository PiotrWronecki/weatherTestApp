namespace WeatherForecastWebApi.Services
{
    using AutoMapper;
    using WeatherForecastWebApi.Repository;
    using WeatherForecastWebApi.ViewModel;

    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository weatherRepository;

        public WeatherService(IWeatherRepository weatherRepository)
        {
            this.weatherRepository = weatherRepository;
        }

        public WeatherViewModel GetWeatherViewModel(string country, string city)
        {
            var results = this.weatherRepository.GetWeather(country, city);
            var model = Mapper.Map<WeatherViewModel>(results);
            return model;
        }
    }
}
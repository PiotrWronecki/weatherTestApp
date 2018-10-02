namespace WeatherForecastWebApi.Services
{
    using WeatherForecastWebApi.ViewModel;

    public interface IWeatherService
    {
        WeatherViewModel GetWeatherViewModel(string country, string city);
    }
}
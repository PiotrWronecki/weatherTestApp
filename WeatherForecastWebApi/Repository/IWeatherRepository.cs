namespace WeatherForecastWebApi.Repository
{
    using WeatherForecastWebApi.Models;

    public interface IWeatherRepository
    {
        WeatherModel GetWeather(string country, string city);
    }
}
namespace WeatherForecastWebApi.Repository
{
    using Newtonsoft.Json;
    using System;
    using System.Configuration;
    using System.Net;
    using WeatherForecastWebApi.Models;

    public class WeatherRepository : IWeatherRepository
    {
        public WeatherModel GetWeather(string country, string city)
        {
            var endpoint = ConfigurationManager.AppSettings.Get("WeatherApiUrl");
            var apiKey = ConfigurationManager.AppSettings.Get("WeatherApiKey");
            using (var webClient = new WebClient())
            {
                webClient.QueryString.Add("q", $"{city},{country}");
                webClient.QueryString.Add("appid", apiKey);
                webClient.QueryString.Add("units", "metric");
                var results = webClient.DownloadString(endpoint);
                var model = JsonConvert.DeserializeObject<WeatherModel>(results);
                return model;
            }
        }
    }
}
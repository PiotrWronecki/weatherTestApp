﻿namespace WeatherForecastWebApi.Models
{
    using Newtonsoft.Json;

    public class Clouds
    {
        [JsonProperty("all")]
        public long All { get; set; }
    }
}
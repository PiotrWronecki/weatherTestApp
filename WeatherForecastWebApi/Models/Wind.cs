﻿namespace WeatherForecastWebApi.Models
{
    using Newtonsoft.Json;

    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("deg")]
        public long Deg { get; set; }
    }
}
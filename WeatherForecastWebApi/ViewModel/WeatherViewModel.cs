namespace WeatherForecastWebApi.ViewModel
{
    public class WeatherViewModel
    {
        public LocationViewModel Location { get; private set; }
        public TemperatureViewModel Temperature { get; private set; }
        public int Humidity { get; private set; }
    }
}
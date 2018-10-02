namespace WeatherForecastWebApi
{
    using AutoMapper;
    using WeatherForecastWebApi.Models;
    using WeatherForecastWebApi.ViewModel;

    public class MapperConfiguration
    {
        public static void Initialize()
        {
            Mapper.Initialize(config=> {
                config.CreateMap<WeatherModel, WeatherViewModel>()
                .ForMember(target => target.Temperature, o => o.MapFrom(s => s.Main))
                .ForMember(target => target.Humidity, o => o.MapFrom(s => s.Main.Humidity))
                .ForPath(target => target.Location.City, o => o.MapFrom(s => s.Name))
                .ForPath(target => target.Location.Country, o => o.MapFrom(s => s.Sys.Country));

                config.CreateMap<Main, TemperatureViewModel>()
                .ForMember(target => target.Value, src => src.MapFrom(a => a.Temp))
                .ForMember(target => target.Format, src => src.UseValue("Celsius"));
            });
        }

    }
}
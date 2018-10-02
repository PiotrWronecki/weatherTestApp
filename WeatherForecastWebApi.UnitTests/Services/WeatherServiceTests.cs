using NSubstitute;
using WeatherForecastWebApi.Models;
using WeatherForecastWebApi.Repository;
using WeatherForecastWebApi.Services;
using WeatherForecastWebApi.ViewModel;
using Xunit;

namespace WeatherForecastWebApi.UnitTests.Services
{
    public class WeatherServiceTests
    {
        private readonly WeatherService weatherService;

        public WeatherServiceTests()
        {
            var weatherRepository = Substitute.For<IWeatherRepository>();
            weatherRepository.GetWeather(Arg.Any<string>(), Arg.Any<string>()).Returns(new WeatherModel());
            this.weatherService = new WeatherService(weatherRepository);
        }

        [Fact]
        public void GetWeatherViewModel_ReturnProperModel()
        {
            // Act
            var result = this.weatherService.GetWeatherViewModel("Test","Test");

            // Assert
            Assert.Equal(typeof(WeatherViewModel), result.GetType());
        }
    }
}

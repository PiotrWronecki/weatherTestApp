namespace WeatherForecastWebApi.UnitTests.Controllers
{
    using NSubstitute;
    using WeatherForecastWebApi.Controllers;
    using WeatherForecastWebApi.Services;
    using Xunit;

    public class WeatherControllerTests
    {
        WeatherController weatherController;
        

        public WeatherControllerTests()
        {
            var weatherService = Substitute.For<IWeatherService>();
            weatherService.GetWeatherViewModel(Arg.Any<string>(), Arg.Any<string>()).Returns(new ViewModel.WeatherViewModel());
            this.weatherController = new WeatherController(weatherService);
        }

        [Theory]
        [InlineData("Poland", "Wrocław")]
        [InlineData("Poland", "Warszawa")]
        public void Weather_ReturnProperViewModel(string country, string city)
        {
            // Act
            var results = this.weatherController.Weather(country, city);

            // Assert
            Assert.Equal("My imaginery location", results.Location);
        }
    }
}

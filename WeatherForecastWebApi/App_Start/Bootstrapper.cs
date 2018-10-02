namespace WeatherForecastWebApi.App_Start
{
    using System.Web.Http;

    public class Bootstrapper
    {
        public static void Run()
        {
            AutofacWebapiConfig.Initialize(GlobalConfiguration.Configuration);
        }
    }
}
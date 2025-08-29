namespace ATWeatherCLI.Classes;

public class WeatherService
{
    //Constructor
    public WeatherService()
    {
        //Nothing to initialize yet
    }

    public WeatherData GetWeather(City city)
    {
        //return sample data for now
        return new WeatherData(22.5, "Sunny", 45, 10);
    }
}
namespace ATWeatherCLI.Classes;

public class WeatherData
{
    public double Temperature { get; set; }
    public string Condition { get; set; }
    public int Humidity { get; set; }
    public double Windspeed { get; set; }
    
    public WeatherData(double temperature, string condition, int humidity, double windspeed)
    {
        Temperature = temperature;
        Condition = condition;
        Humidity = humidity;
        Windspeed = windspeed;
    }
    
    public override string ToString()
    {
        return $"Temperature: {Temperature}°C, Condition: {Condition}, Humidity: {Humidity}%, Windspeed: {Windspeed} km/h";
    }
}
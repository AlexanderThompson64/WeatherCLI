// See https://aka.ms/new-console-template for more information

using ATWeatherCLI.Classes;

// var city = new City("Newcastle", "NE21 4DB");
// var weatherService = new WeatherService();
// var weather = weatherService.GetWeather(city);
//
// Console.WriteLine($"Weather for {city}: {weather}");

Console.WriteLine("Welcome to the AT Weather CLI!");
Console.WriteLine("Please enter a UK postcode: ");
string postcode = Console.ReadLine() ?? "";

var city = new City("Unknown", postcode);
var weatherService = new WeatherService();
var weather = weatherService.GetWeather(city);

Console.WriteLine($"\nWeather for {city}:\n{weather}");


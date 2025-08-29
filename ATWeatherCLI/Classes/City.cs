namespace ATWeatherCLI.Classes;

public class City
{
    public string Name { get; set; }
    public string Postcode{ get; set; }

    public City(string name, string postcode)
    {
        Name = name;
        Postcode = postcode;
    }
    
    public override string ToString()
    {
        return $"{Name} ({Postcode})";
    }
}
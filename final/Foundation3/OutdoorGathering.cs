public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string Weather, string Title, string Description, string date, string time, string Address) : base(Title, Description, time, date, Address)
    {
        _weather = Weather;
    }
    public string GetWeather()
    {
        return _weather;
    }
    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} \nBe awrare that the weather will be {_weather}!";
    }
}
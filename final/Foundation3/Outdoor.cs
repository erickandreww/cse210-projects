using System; 

class Outdoor : Event 
{
    private string _weather; 

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _eventType = "Outdoor Gathering Event";
        _weather = weather;
        _eventInfo = GetInfo();
    }

    public string GetInfo() 
    {
        return $"Weather: {_weather}";
    }
}
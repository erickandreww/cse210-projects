using System; 

class Outdoor : Event 
{
    // a variable to hold weather info
    private string _weather; 

    // a contrutor to set the event type, weather, and the class details
    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _eventType = "Outdoor Gathering Event";
        _weather = weather;
        _eventInfo = GetInfo();
    }

    // A method to return a string with weather information
    public string GetInfo() 
    {
        return $"Weather: {_weather}";
    }
}
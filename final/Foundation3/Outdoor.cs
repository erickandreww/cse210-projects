using System; 

class Outdoor : Event 
{
    private string _weather; 

    public Outdoor(string title, string description, string date, string time, string address, string speaker, int capacity, string weather) : base(title, description, date, time, address)
    {
        _eventType = "Outdoor Gathering Event";
        _eventInfo = "Information";
        _weather = weather;
    }
}
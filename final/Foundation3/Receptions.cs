using System; 

class Receptions : Event 
{
    private string _rsvp;

    public Receptions(string title, string description, string date, string time, string address, string rsvp) : base(title, description, date, time, address)
    {
        _eventType = "Reception Event";
        _rsvp = rsvp;
        _eventInfo = GetInfo();
    }

    public string GetInfo() 
    {
        return $"RSVP: {_rsvp}";
    }
}
using System; 

class Receptions : Event 
{
    // // a variable to hold the RSVP
    private string _rsvp;

    // a contrutor to set the event type, RSVP, and the class details
    public Receptions(string title, string description, string date, string time, string address, string rsvp) : base(title, description, date, time, address)
    {
        _eventType = "Reception Event";
        _rsvp = rsvp;
        _eventInfo = GetInfo();
    }

    // A method to return a string with RSVP
    public string GetInfo() 
    {
        return $"RSVP: {_rsvp}";
    }
}
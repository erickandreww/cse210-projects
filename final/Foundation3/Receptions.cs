using System; 

class Receptions : Event 
{
    private string _rsvp;

    public Receptions(string title, string description, string date, string time, string address, string speaker, int capacity, string rsvp) : base(title, description, date, time, address)
    {
        _eventType = "Reception Event";
        _eventInfo = "Information";
        _rsvp = rsvp;
    }
}
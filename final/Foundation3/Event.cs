using System; 

class Event
{
    protected string _title; 
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;
    protected string _eventInfo;

    public Event(string title, string description, string date, string time, string address) 
    {
        _title = title;
        _description = description; 
        _date = date;
        _time = time; 
        _address = address;
    }

    public void Standard() 
    {
        // Lists the title, description, date, 
        // time, and address.
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"{_date} at {_time}");
        Console.WriteLine($"Location: {_address}");
    }

    public void Full()
    {
        // Lists all of the above, plus 
        // type of event and information specific to that event type.

        // For lectures, this includes the speaker name and capacity. 
        // For receptions this includes an email for RSVP. 
        // For outdoor gatherings, this includes a statement of the weather.
        Standard();
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"{_eventInfo}");


    }

    public void Short()
    {
        // Lists the type of event, title, and the date.
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"{_date}");
    }

}
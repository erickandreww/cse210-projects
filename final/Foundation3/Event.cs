using System; 

class Event
{
    // variables to hold all necessary information
    protected string _title; 
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;
    protected string _eventInfo;

    // a contructor to define general information, that are title. description, date, time and address
    public Event(string title, string description, string date, string time, string address) 
    {
        _title = title;
        _description = description; 
        _date = date;
        _time = time; 
        _address = address;
    }

    // Standard details - Lists the title, description, date, time, and address.
    public void Standard() 
    {
        // Lists the title, description, date, 
        // time, and address.
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"\"{_description}\"");
        Console.WriteLine($"Date: {_date} at {_time}");
        Console.WriteLine($"Location: {_address}");
    }

    // Full details - Lists all of the Standard method information, plus type of event and information specific to that event type.
    public void Full()
    {
        // Lists all of the above, plus 
        // type of event and information specific to that event type.

        // For lectures, this includes the speaker name and capacity. 
        // For receptions this includes an email for RSVP. 
        // For outdoor gatherings, this includes a statement of the weather.
        Standard();
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine(_eventInfo);
    }

    // Short description - Lists the type of event, title, and the date.
    public void Short()
    {
        // Lists the type of event, title, and the date.
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Event Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }

}
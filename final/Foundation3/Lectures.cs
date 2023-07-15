using System; 

class Lectures : Event 
{
    // variables to hold the speaker and capacity info
    private string _speaker;
    private int _capacity;

    // a contrutor to set the event type, speaker, capacity, and the class details
    public Lectures(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _eventType = "Lectures Event";
        _speaker = speaker;
        _capacity = int.Parse(capacity);
        _eventInfo = GetInfo();
    }

    // A method to return a string with the speaker and the people capacity of the event
    public string GetInfo()
    {
        return $"Speaker: {_speaker} \nPeople Capacity: {_capacity}";
    }
}
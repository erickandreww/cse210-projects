using System; 

class Lectures : Event 
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, string address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _eventType = "Lectures Event";
        _eventInfo = "Information";
        _speaker = speaker;
        _capacity = capacity;
    }
}
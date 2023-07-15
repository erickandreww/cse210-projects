using System; 

class Lectures : Event 
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _eventType = "Lectures Event";
        _speaker = speaker;
        _capacity = int.Parse(capacity);
        _eventInfo = GetInfo();
    }

    public string GetInfo()
    {
        return $"Speaker: {_speaker} \nPeople Capacity: {_capacity}";
    }
}
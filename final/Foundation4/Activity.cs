using System;

class Activity
{
    // protected variables to keep geral activity informations
    protected string _activityType;
    protected string _date;
    protected int _length;

    // The base Construtor to hold date and minutes information
    protected Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    // date and length will be "insired" by the user.
    // but the distance, speed and pace will be calculated.

    // A GetSummary module to print all the Activities information
    public void GetSummary()
    {
        double speed = GetSpeed();
        double pace = GetPace();

        if (_activityType == "Stationary Bicycles") {
            Console.WriteLine($"{_date} {_activityType} ({_length} min) - Speed {speed:F1} kph, Pace: {pace:F1} min per km");
        }
        else {
            double distance = GetDistance();
            Console.WriteLine($"{_date} {_activityType} ({_length} min) - Distance {distance:F1} km, Speed {speed:F1} kph, Pace: {pace:F1} min per km");
        }
    }
    // A virtual module to get the distance
    public virtual double GetDistance()
    {
        return 0;
    }
    // A virtual module to get the speed
    public virtual double GetSpeed()
    {
        return 0;
    }
    // A virtual module to get the pace
    public virtual double GetPace() 
    {
        return 0;
    }
}
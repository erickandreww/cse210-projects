using System;

class Swimming : Activity
{
    // variable to hold the number of laps
    private int _nLaps;
    
    // A construtor to set the name of the activity and number of laps
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _activityType = "Cycling";
        _nLaps = laps;
    }

    // All the Get's modules and calculations
    public override double GetDistance()
    {
        return _nLaps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double speed = (distance / _length) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double speed = GetSpeed();
        double pace = 60 / speed;
        return pace;
    }
}
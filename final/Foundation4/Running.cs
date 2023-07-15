using System;

class Running : Activity
{
    // variable to hold the distance
    private double _distance;

    // A construtor to set the name of the activity and the distance
    public Running(string date, int length, double distance) : base(date, length)
    {
        _activityType = "Running";
        _distance = distance;
    }

    // All the Get's modules and calculations
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _length) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _length / _distance;
        return pace;
    }
}
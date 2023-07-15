using System;

class Cycling : Activity
{
    // variable to hold the speed
    private double _speed;

    // A construtor to set the name of the activity and the speed
    public Cycling(string date, int length, double speed) : base(date, length)
    {
        _activityType = "Stationary Bicycles";
        _speed = speed;
    }

    // All the Get's modules and calculations, the Cycling activity don't have the distance atribute
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }


}
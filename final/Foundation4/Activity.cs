using System;

class Activity
{
    protected string _activityType;
    protected string _date;
    protected float _length;
    protected float _distance;
    protected float _speed;
    protected float _pace;

    // date and length will be "insired" by the user.
    // but the distance, speed and pace will be calculated.


    public void GetSummary()
    {
        Console.WriteLine($"{_date} {"Activity name"} ({_length}) - Distance {_distance}, Speed {_speed} kph, Pace: {_pace} min per km");
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.9 min per km
    }

    protected virtual double GetAttribute()
    {
        return 1.2;
    }
}
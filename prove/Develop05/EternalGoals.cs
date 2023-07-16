using System;

public class EternalGoals : Goals
{
    
    public EternalGoals() : base()
    {
        _activityName = "EternalGoals";
        _goalStatus = false;
    }

    public EternalGoals(string activityName, string goalName, string description, 
    string pointsValue) : base(activityName, goalName, description, pointsValue)
    {
    }

    public override string GetGoal() 
    {
        return $"{_activityName},{_goalName},{_description},{_pointsValue}";
    }

    public override int Complete()
    {
        Console.WriteLine($"Congratulations! You have earned {_pointsValue} points!");
        return _pointsValue;
    }

    public override string Display()
    {
        return $"[ ] {_goalName} ({_description})";
    }
}
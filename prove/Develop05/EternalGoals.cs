using System;

public class EternalGoals : Goals
{
    
    public EternalGoals() : base()
    {
        _activityName = "EternalGoals";
        _goalStatus = false;
    }

    public override string GetGoal() 
    {
        return $"{_activityName},{_goalName},{_description},{_pointsValue},{_goalStatus}";
    }

    public override string Display()
    {
        return $"[ ] {_goalName}, ({_description})";
    }
}
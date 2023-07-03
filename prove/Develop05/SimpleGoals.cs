using System;

public class SimpleGoals : Goals
{
    public SimpleGoals() : base()
    {
        _activityName = "SimpleGoals";
    }

    public override string GetGoal() 
    {
        return $"{_activityName},{_goalName},{_description},{_pointsValue},{_goalStatus}";
    }

    public override string Display()
    {
        StatusOfGoal();
        return $"[{_isCompleted}] {_goalName}, ({_description})";
    }
}
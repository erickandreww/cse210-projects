using System;

public class EternalGoals : Goals
{
    
    // A constructor to get the goal initial information
    public EternalGoals() : base()
    {
        _activityName = "EternalGoals";
        _goalStatus = false;
    }

    // a constructor to work with tha save and load class
    public EternalGoals(string activityName, string goalName, string description, 
    string pointsValue) : base(activityName, goalName, description, pointsValue)
    {
    }

    // method to return the goal in a string
    public override string GetGoal() 
    {
        return $"{_activityName},{_goalName},{_description},{_pointsValue}";
    }

    // an override method to mark the goal complete and return the points
    public override int Complete()
    {
        Console.WriteLine($"Congratulations! You have earned {_pointsValue} points!");
        return _pointsValue;
    }

    // an override method to display the goal name, description, and if is completed or not
    public override string Display()
    {
        return $"[ ] {_goalName} ({_description})";
    }
}

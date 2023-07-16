using System;

public class SimpleGoals : Goals
{
    public SimpleGoals() : base()
    {
        _activityName = "SimpleGoals";
    }

    public SimpleGoals(string activityName, string goalName, string description, string pointsValue, 
    string boolean) : base(activityName, goalName, description, pointsValue)
    {
        if (boolean == "True") {
            _goalStatus = true;
        }
        else {
            _goalStatus = false;
        }
    }

    public override string GetGoal() 
    {
        if (_goalStatus == true) {
            return $"{_activityName},{_goalName},{_description},{_pointsValue},True";
        }
        else {
            return $"{_activityName},{_goalName},{_description},{_pointsValue},False";
        }
    }

    public override int Complete()
    {
        if (_goalStatus == true) {
            Console.WriteLine("This goal has already been completed");
            return 0;
        }
        else {
            Console.WriteLine($"Congratulations! You have earned {_pointsValue} points!");
            _goalStatus = true;
            return _pointsValue;
        }
    }

    public override string Display()
    {
        StatusOfGoal();
        return $"[{_isCompleted}] {_goalName} ({_description})";
    }
}
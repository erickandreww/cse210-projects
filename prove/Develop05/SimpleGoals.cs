using System;

public class SimpleGoals : Goals
{

    // A constructor to get the goal initial information
    public SimpleGoals() : base()
    {
        _activityName = "SimpleGoals";
    }

    // a constructor to work with the save and load class
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

    // method to return the goal in a string
    public override string GetGoal() 
    {
        if (_goalStatus == true) {
            return $"{_activityName},{_goalName},{_description},{_pointsValue},True";
        }
        else {
            return $"{_activityName},{_goalName},{_description},{_pointsValue},False";
        }
    }

    // an override method to mark the goal complete and return the points
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
    
    // an override method to display the goal name, description, and if it is completed or not
    public override string Display()
    {
        StatusOfGoal();
        return $"[{_isCompleted}] {_goalName} ({_description})";
    }
}

using System;

public abstract class Goals 
{
    // Variables to hold the activities information
    protected string _activityName;
    protected string _goalName;
    protected string _description;
    protected int _pointsValue;
    protected bool _goalStatus;
    protected string _isCompleted;

    // A constructor to get the goal initial information
    public Goals() 
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsValue = int.Parse(Console.ReadLine());
    }

    // a constructor to work with the save and load class
    public Goals(string activityName, string goalName, string description, string pointsValue)
    {
        _goalName = goalName;
        _description = description;
        _pointsValue = int.Parse(pointsValue);
        _activityName = activityName;
    }

    // an abstract method to return the goal in a string
    public abstract string GetGoal();

    // a method to return the goal name
    public string GetName()
    {
        return _goalName;
    }

    // a method to display the goal
    public abstract string Display();

    // a method to mark the goal complete, also return the points
    public abstract int Complete();

    // a method to verify the goal status and mark with "X" the completed goals
    protected void StatusOfGoal()
    {
        if (_goalStatus == true) {
            _isCompleted = "X";
        }
        else {
        _isCompleted = " ";
        }
    }
}

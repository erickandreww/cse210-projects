using System;

public abstract class Goals 
{
    protected string _activityName;
    protected string _goalName;
    protected string _description;
    protected int _pointsValue;
    protected bool _goalStatus;
    protected string _isCompleted;

    public Goals() 
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _pointsValue = int.Parse(Console.ReadLine());
    }

    public Goals(string activityName, string goalName, string description, string pointsValue)
    {
        _goalName = goalName;
        _description = description;
        _pointsValue = int.Parse(pointsValue);
        _activityName = activityName;
    }

    public abstract string GetGoal();

    public string getName()
    {
        return _goalName;
    }

    public abstract string Display();

    public abstract int Complete();

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
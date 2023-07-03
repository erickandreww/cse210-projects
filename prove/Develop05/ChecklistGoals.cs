using System;

public class ChecklistGoals : Goals
{
    private int _bonusPoints;
    private int _numberTimes;
    private int _actualTime;

    public ChecklistGoals() : base()
    {
        _activityName = "ChecklistGoals";
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _numberTimes = int.Parse(Console.ReadLine());
    }

    public override string GetGoal() 
    {
        return $"{_activityName},{_goalName},{_description},{_pointsValue},{_goalStatus},{_numberTimes},{_actualTime}";
    }
    
    public override string Display()
    {
        StatusOfGoal();
        return $"[{_isCompleted}] {_goalName}, ({_description}) -- Currently completed {_numberTimes}/{_actualTime}";
    }
    
}
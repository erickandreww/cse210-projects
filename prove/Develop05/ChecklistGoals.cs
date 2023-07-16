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
        _numberTimes = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _actualTime = 0;
    }
    public ChecklistGoals(string activityName, string goalName, string description, string pointsValue, 
    string bonus, string actualTimes, string times) : base(activityName, goalName, description, pointsValue)
    {
        _bonusPoints = int.Parse(bonus);
        _numberTimes = int.Parse(times);
        _actualTime = int.Parse(actualTimes);
        if (_actualTime == _numberTimes) {
            _goalStatus = true;
        }
        else {
            _goalStatus = false;
        }
    }

    public override string GetGoal() 
    {
        return $"{_activityName},{_goalName},{_description},{_pointsValue},{_bonusPoints},{_actualTime},{_numberTimes}";
    }

    public override int Complete() {
        if (_actualTime == _numberTimes) {
            Console.WriteLine("This goal has already been completed");
            return 0;
        }
        else {
            _actualTime += 1;
            int pointsToReturn = _pointsValue;
            if (_actualTime == _numberTimes) {
                _goalStatus = true;
                pointsToReturn =+ _bonusPoints;
            }
            Console.WriteLine($"Congratulations! You have earned {pointsToReturn} points!");
            return pointsToReturn;
        }
    }
    
    public override string Display()
    {
        StatusOfGoal();
        return $"[{_isCompleted}] {_goalName} ({_description}) -- Currently completed {_actualTime}/{_numberTimes}";
    }
    
}
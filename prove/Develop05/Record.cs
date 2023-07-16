using System;

class Record
{
    private string _filename;
    private int _points;
    private string _goal;
    List<Goals> _myGoals = new List<Goals>();

    public Record(string filename)
    {
        _filename = filename;
    }
    public Record(List<Goals> list, string filename, int points)
    {
        _filename = filename;
        _myGoals = list;
        _points = points;
    }

    public void Saving() 
    {
        string csvFilename = _filename + ".csv";

        using (StreamWriter outputFile = new StreamWriter(csvFilename))
        {
            outputFile.WriteLine(_points);
            foreach (Goals goal in _myGoals)
            {
                _goal = goal.GetGoal();
                outputFile.WriteLine(_goal);
            }
        }
    }

    public List<Goals> Loading()
    {
        string csvFilename = _filename + ".csv";
        string[] lines = System.IO.File.ReadAllLines(csvFilename);
        bool next = false;
        foreach (string line in lines) {
            if (next == false) {
                next = true;
                _points = int.Parse(line);
            }
            else {
                string[] goals = line.Split(",");
                if (goals[0] == "SimpleGoals") {
                    SimpleGoals simple = new SimpleGoals(goals[0], goals[1], goals[2], 
                    goals[3], goals[4]);
                    _myGoals.Add(simple);
                }
                else if (goals[0] == "EternalGoals") {
                    EternalGoals etern = new EternalGoals(goals[0], goals[1], goals[2], goals[3]);
                    _myGoals.Add(etern);
                }
                else if (goals[0] == "ChecklistGoals") {
                    ChecklistGoals check = new ChecklistGoals(goals[0], goals[1], goals[2], 
                    goals[3], goals[4], goals[5], goals[6]);
                    _myGoals.Add(check);
                }
            }          
        }
        return _myGoals;
    }

    public void SetPoints(int points) 
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    // need to call the goal and put the goal acording to the goal type
}
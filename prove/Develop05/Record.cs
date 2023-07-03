using System;

class Record
{
    private string _filename;
    private int _points;
    private string _goal;
    List<Goals> _myGoals = new List<Goals>();

    public void Saving(List<Goals> list, string filename) 
    {
        _filename = filename;
        _myGoals = list;
        
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

    public void SetPoints(int points) 
    {
        _points = points;
    }
}
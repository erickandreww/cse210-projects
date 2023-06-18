using System;

public class Activity 
{
    protected string _activityName; 
    protected string _description;
    protected int _time; 
    List<string> _animationString = new List<string>();

    public string FirstMessage() 
    {
        return $"Welcome to the {_activityName} \n \n {_description}";
    }

    protected void getReady() 
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(3);
    } 

    public void Spinner(int time) {
        animationAdd();
        _time = time;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        int i = 0;
        while (DateTime.Now < endTime) {
            string s = _animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= _animationString.Count) {
                i = 0;
            }
        }
    }

    public void countDown(int time)
    {
        _time = time;
        for (int i = time; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void animationAdd() {
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
        _animationString.Add("|");
        _animationString.Add("/");
        _animationString.Add("-");
        _animationString.Add("\\");
    }
}
using System;

public class Activity 
{
    protected string _activityName; 
    protected string _description;
    protected int _time; 
    protected List<string> _animationString = new List<string>();

    public void FirstMessage() 
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} \n \n{_description}");
    }

    public void LastMessage() 
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed another {_time} seconds of {_activityName}.");
        Spinner(5);
    }

    protected void GetReady() 
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(3);
    } 

    public void Spinner(int time) {
        animationAdd();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;
        while (DateTime.Now < endTime) {
            string s = _animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= _animationString.Count) {
                i = 0;
            }
        }
    }

    public void countDown(int time)
    {
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
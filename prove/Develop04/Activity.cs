using System;

public class Activity 
{
    protected string _activityName; 
    protected string _description;
    protected int _time; 
    protected List<string> _animationString = new List<string>();

    // This module will print the initial message of the activities, with it's name and description.
    public void FirstMessage() 
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} \n \n{_description}");
    }

    // This module will print the final message of the activities.
    public void LastMessage() 
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed another {_time} seconds of {_activityName}.");
        Spinner(5);
    }

    // this module wil run the get ready prompt for all the activities.
    protected void GetReady() 
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Spinner(3);
    } 

    // This module will run the Spinnet animation for all the other classes
    public void Spinner(int time) {
        AnimationAdd();
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

    // this module will suport all the other classes with a countdown time
    public void CountDown(int time)
    {
        for (int i = time; i > 0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // This module will add the animation spinner to the list
    private void AnimationAdd() {
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
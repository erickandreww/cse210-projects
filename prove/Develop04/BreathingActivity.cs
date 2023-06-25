using System;

class BreathingActivity : Activity
{
    private string _b1;
    private string _b2;

    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _description = "This activity will help you relax by walking yoir through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _b1 = "Breathe in...";
        _b2 = "Breathe out...";
    }

    // this module is the main module for the activity works.
    public void StartBreathing(int time) 
    {
        _time = time;
        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while ((DateTime.Now < endTime)) {
            Console.WriteLine();
            Console.Write(_b1);
            CountDown(4);
            Console.WriteLine();
            Console.Write(_b2);
            CountDown(6);
            Console.WriteLine();
        }

    }
}
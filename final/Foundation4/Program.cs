using System;

class Program
{
    static void Main(string[] args)
    {
        // List of Activities
        Console.WriteLine("Welcome to Exercise Tracking Program \n\n");
        List<Activity> activityList = new List<Activity>();
        // Call Runing Activity
        Running run = new Running("6 Jul 2023", 30, 3);
        activityList.Add(run);
        // Call Swimming Activity
        Swimming swin = new Swimming("7 Jul 2023", 40, 30);
        activityList.Add(swin);
        // Call Cycling Activity
        Cycling cycli = new Cycling("8 Jul 2023", 60, 9.7);
        activityList.Add(cycli);
        // a for loop to call the GetSummary for each activity
        foreach (Activity activity in activityList) {
            activity.GetSummary();
            Console.WriteLine();
        }

    }
}
using System;

class ReflectingActivity : Activity
{
    private string _reflectionMessage;
    List<string> _reflectionQuestions = new List<string>();

    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect";
    }

    public void startReflection(int time) 
    {
        _time = time;
        getReady();

        Console.WriteLine("Consider the following prompt: ");
        randomPrompt();
        Console.WriteLine($"--- {_reflectionMessage} ---");
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.Write("You may begin in: ");
        countDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while ((DateTime.Now < endTime)) {
            Console.Write("> How did you feel when it was complete? ");
            Spinner(15);
        }
        
        Console.WriteLine("Well Done!!");
        Console.WriteLine($"You have completed another {_time} seconds of Reflecting Activity");
        Spinner(5);
    }

    private void randomPrompt() {
        _reflectionMessage = "Think of a time when you did something really dificult.";
    }



    // a module to add random messages, but without repeat any;
}
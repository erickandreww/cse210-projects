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

    public void startReflection() 
    {
        FirstMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
        getReady();

        Console.WriteLine("Consider the following prompt: ");
        randomPrompt();
        Console.WriteLine(_reflectionMessage);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        
        
    }

    private void randomPrompt() {
        _reflectionMessage = "--- Think of a time when you did something really dificult. ---";
    }



    // a module to add random messages, but without repeat any;
}
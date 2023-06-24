using System;

class ReflectingActivity : Activity
{
    private string _reflectionMessage;
    private string _reflectionQuestion;
    private List<string> _reflectionMessages = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();

    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void startReflection(int time) 
    {
        _time = time;
        GetReady();

        Console.WriteLine("Consider the following prompt: \n");
        randomReflectionMessage();
        Console.WriteLine($"--- {_reflectionMessage} ---");
        Console.Write("\nWhen you have something in mind, press enter to continue. ");
        Console.ReadLine();

        Console.Write("You may begin in: ");
        countDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while ((DateTime.Now < endTime)) {
            randomReflectionQuestion();
            Console.Write($"> {_reflectionQuestion} ");
            Spinner(5);
            if (DateTime.Now > endTime) {
                break;
            }
            Spinner(5);
            Console.WriteLine();            
        }
        Console.WriteLine();   
    }

    private void randomReflectionMessage() {
        addOnLists();

        Random rNumber = new Random();
        int number = rNumber.Next(_reflectionMessages.Count);

        _reflectionMessage = _reflectionMessages[number];
    }

    private void randomReflectionQuestion() 
    {
        Random rNumber = new Random();
        int number = rNumber.Next(_reflectionQuestions.Count);

        _reflectionQuestion = _reflectionQuestions[number];
    }

    private void addOnLists() {
        _reflectionMessages.Add("Think of a time when you stood up for someone else.");
        _reflectionMessages.Add("Think of a time when you did something really difficult.");
        _reflectionMessages.Add("Think of a time when you helped someone in need.");
        _reflectionMessages.Add("Think of a time when you did something truly selfless.");

        _reflectionQuestions.Add("Why was this experience meaningful to you?");
        _reflectionQuestions.Add("Have you ever done anything like this before?");
        _reflectionQuestions.Add("How did you get started?");
        _reflectionQuestions.Add("How did you feel when it was complete?");
        _reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        _reflectionQuestions.Add("What is your favorite thing about this experience?");
        _reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        _reflectionQuestions.Add("What did you learn about yourself through this experience?");
        _reflectionQuestions.Add("How can you keep this experience in mind in the future?");        
    }
}
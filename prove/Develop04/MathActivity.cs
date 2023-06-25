using System;

class MathActivity : Activity
{
    private int _mathAccount; 
    private List<string> _mathQuestions = new List<string>();
    private int _rNumber1;
    private int _rNumber2;
    private int _symbolNumber;
    private int _incorrect;
    private int _correct;


    public MathActivity()
    {
        _activityName = "Math Activity";
        _description = "This activity will help foster mindfulness by engaging us in the present moment through the intricate and precise nature of mathematics. By immersing ourselves in each step, embracing curiosity, and maintaining focus, math becomes a pathway to clarity and deep engagement, enabling us to cultivate mindfulness.";
        _incorrect = 0;
        _correct = 0;
    }

    // this module is the main module for the activity works.
    public void StartMath(int time)
    {
        _time = time;
        GetReady();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while ((DateTime.Now < endTime)) {
            Console.WriteLine("Solve the following math acount");
            AccountConstructor();
            if (_symbolNumber == 1) {
                Console.WriteLine($"{_rNumber1} + {_rNumber2}");
                _mathAccount = _rNumber1 + _rNumber2;
            }
            else if (_symbolNumber == 2) {
                Console.WriteLine($"{_rNumber1} - {_rNumber2}");
                _mathAccount = _rNumber1 - _rNumber2;
            }
            else if (_symbolNumber == 3) {
                Console.WriteLine($"{_rNumber1} x {_rNumber2}");
                _mathAccount = _rNumber1 * _rNumber2;                
            }
            Console.Write(" > ");
            int results = int.Parse(Console.ReadLine());
            if (results == _mathAccount) {
                _correct ++;
            }
            else {
                _incorrect ++;
            }
        }    
        Console.WriteLine($"You got {_correct} right. ");
        Console.WriteLine($"You missed {_incorrect}. ");  
    }

    // This module will set random numbers between 1 and 99.
    private void AccountConstructor() 
    {
        Random number = new Random();
        _rNumber1 = number.Next(1, 99);
        _rNumber2 = number.Next(1, 99);

        _symbolNumber = number.Next(1, 3);
    }


}
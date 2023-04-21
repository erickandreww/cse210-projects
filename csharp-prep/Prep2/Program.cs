using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Insert Your grade percentage: ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        int lastDigit = grade % 10;

        if (grade >= 90) 
        {
            if (lastDigit < 3 && grade < 93) 
            {
                Console.WriteLine("Your Grade is -A");
            }
            else 
            {
                Console.WriteLine("Your Grade is A");
            }
        }
        else if (grade >= 80)
        {
            if (lastDigit < 3) 
            {
                Console.WriteLine("Your Grade is -B");
            }
            else 
            {
                Console.WriteLine("Your Grade is B");
            }
        }
        else if (grade >= 70)
        {
            if (lastDigit < 3) 
            {
                Console.WriteLine("Your Grade is -C");
            }
            else 
            {
                Console.WriteLine("Your Grade is C");
            }
        }
        else if (grade >= 60)
        {
            if (lastDigit < 3) 
            {
                Console.WriteLine("Your Grade is -D");
            }
            else 
            {
                Console.WriteLine("Your Grade is D");
            }
        }
        else 
        {
            Console.WriteLine("Your Grade is F");
        }

        if (grade >= 70) 
        {
            Console.WriteLine("Congratulations! You successfully passed.");
        }
        else 
        {
            Console.WriteLine("Unfortunately you didn't pass this time, but don't give up, try again!!");
        }
    }
}
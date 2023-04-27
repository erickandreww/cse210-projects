using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            bool hit = false; 
            int i = 1; 
            while (hit == false) 
            {
                Console.Write("What is the magic number? ");
                string guessStr = Console.ReadLine();
                int guess = int.Parse(guessStr);
                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < magicNumber) 
                {
                    Console.WriteLine("Higher");
                }
                else 
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"You tried {i} times");
                    hit = true; 
                    
                }
                i++;
            }
            Console.Write("Do you want to continue (yes/no)? ");
            string userResponse = Console.ReadLine();
            if (userResponse == "yes")
            {
                response = "yes";
                hit = false;
            }
            else 
            {
                response = "no";
            }
        }
    }
}
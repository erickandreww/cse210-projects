using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your Name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number: ");
        string askNumber = Console.ReadLine();
        int favNumber = int.Parse(askNumber);
        return favNumber;
    }

    static int SquareNumber(int number)
    {
        int SquaredNumber = number * number; 
        return SquaredNumber;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}
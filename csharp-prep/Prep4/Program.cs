using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 0;
        do 
        {
            Console.Write("Enter number: ");
            string enter = Console.ReadLine();
            number = int.Parse(enter);
            if (number != 0) 
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int count = 0;
        int sum = 0;
        int largest = 0;
        foreach (int n in numbers) 
        {
            sum += n;
            if (n >= largest)
            {
                largest = n;
            }
            count ++;
        }
        float average = ((float)sum) / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The lasgest number is: {largest}");
    }
}
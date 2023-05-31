using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fr1 = new Fraction();
        string ex1 = fr1.GetFractionString();
        double ex2 = fr1.GetDecimalValue();

        Fraction fr2 = new Fraction(5);
        string ex3 = fr2.GetFractionString();
        double ex4 = fr2.GetDecimalValue();

        Fraction fr3 = new Fraction(3,4);
        string ex5 = fr3.GetFractionString();
        double ex6 = fr3.GetDecimalValue();

        Fraction fr4 = new Fraction(1,3);
        string ex7 = fr4.GetFractionString();
        double ex8 = fr4.GetDecimalValue();

        Console.WriteLine(ex1);
        Console.WriteLine(ex2);
        Console.WriteLine(ex3);
        Console.WriteLine(ex4);
        Console.WriteLine(ex5);
        Console.WriteLine(ex6);
        Console.WriteLine(ex7);
        Console.WriteLine(ex8);
    }
}
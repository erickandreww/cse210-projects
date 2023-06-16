using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assign = new Assignment("Erick", "Multiplication");
        assign.GetSummary();

        MathAssignment math1 = new MathAssignment("Erick Moura", "Fractions", "Section 7.3", "Problems 8-19");
        math1.GetHomeworkList();
        
        WritingAssignment write1 = new WritingAssignment("Erick Moura", "European History", "The Causes of World War II by Mary Waters");
        write1.GetWritingInformation();


        Console.WriteLine(assign.GetSummary());
        Console.WriteLine();
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(write1.GetWritingInformation());
        Console.WriteLine();
    }
}
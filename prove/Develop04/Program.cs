using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to Mindfulness Activities Program!");
        Console.WriteLine();

        bool end = false;
        List <string> menu = new List <string> 
            {"   1. Breathing Activity","   2. Reflecting Activity", 
            "   3. Listing Activity", "   4. Quit"};
        

        while (end  == false) {
            foreach (string men in menu) {Console.WriteLine(men);}
            Console.Write("Select a choise from the menu: ");
            string select = Console.ReadLine();
            
            if (select == "1") {
                Console.WriteLine(1);
                // call the tilte and description module
                // call the user question time module;
                // getready funtion and spinner funtion
                string startTime = Console.ReadLine();
                // take the time for the loop
                // a loop to call breath in and breath out 
                // while the selected time don't finish. 
                // n
            }
            else if (select == "2") {
                Console.WriteLine(2);
                ReflectingActivity refl = new ReflectingActivity();
                refl.FirstMessage();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                refl.startReflection(time);
            }
            else if (select == "3") {
                Console.WriteLine(3);
            }
            else if (select == "4") {
                Console.WriteLine();
                Console.WriteLine("Thank you for your participation!");                
            }
            else {
                Console.WriteLine("Please insert a corect answer");
                end = false;
            }


            end = true;
        }
    }
}
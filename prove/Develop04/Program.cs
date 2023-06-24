using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to Mindfulness Activities Program!");

        bool end = false;
        bool firstTime = false;
        List <string> menu = new List <string> 
            {"   1. Breathing Activity","   2. Reflecting Activity", 
            "   3. Listing Activity", "   4. Quit"};
        

        while (end  == false) {
            Console.WriteLine();
            if (firstTime == true) {
                Console.Clear();
            }
            Console.WriteLine("Menu Options");
            foreach (string men in menu) {Console.WriteLine(men);}
            Console.Write("Select a choise from the menu: ");
            string select = Console.ReadLine();
            
            if (select == "1") {
                Console.WriteLine(1);
                BreathingActivity breath = new BreathingActivity();
                breath.FirstMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                breath.startBreathing(time);
                breath.LastMessage();
            }
            else if (select == "2") {
                ReflectingActivity refl = new ReflectingActivity();
                refl.FirstMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                refl.startReflection(time);
                refl.LastMessage();
            }
            else if (select == "3") {
                ListingActivity list = new ListingActivity();
                list.FirstMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                list.startListing(time);
                list.LastMessage();
            }
            else if (select == "4") {
                Console.WriteLine();
                Console.WriteLine("Thank you for your participation!");   
                end = true;             
            }
            else {
                Console.WriteLine("Please insert a corect answer");
                end = false;
            }
            firstTime = true;
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Welcome to Mindfulness Activities Program!");

        bool end = false;
        bool firstTime = false;
        // A list to show the menu
        List <string> menu = new List <string> 
            {"   1. Breathing Activity","   2. Reflecting Activity", 
            "   3. Listing Activity", "   4. Math Activity", "   5. Quit"};
        
        // while loop that will display all the activities
        while (end  == false) {
            // a if statement to verify if is the first time runing the loop or no
            Console.WriteLine();
            if (firstTime == true) {
                Console.Clear();
            }
            // printing menu options
            Console.WriteLine("Menu Options");
            foreach (string men in menu) {Console.WriteLine(men);}
            Console.Write("Select a choise from the menu: ");
            string select = Console.ReadLine();
            // Breathing Activity will run
            if (select == "1") {
                Console.WriteLine(1);
                // call the class
                BreathingActivity breath = new BreathingActivity();
                // call a module to print the first message
                breath.FirstMessage();
                Console.WriteLine();
                // take how many time from the user
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                // calling the main module of the class
                breath.startBreathing(time);
                // printing the last part of the activity
                breath.LastMessage();
            }
            // Reflecting Activity will run
            else if (select == "2") {
                ReflectingActivity refl = new ReflectingActivity();
                refl.FirstMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                refl.startReflection(time);
                refl.LastMessage();
            }
            // Listing Activity will run
            else if (select == "3") {
                ListingActivity list = new ListingActivity();
                list.FirstMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                list.startListing(time);
                list.LastMessage();
            }
            // Math Activity, is a additional activity
            else if (select == "4") {
                MathActivity math = new MathActivity();
                math.FirstMessage();
                Console.WriteLine();
                Console.Write("How long, in seconds, would you like for your session? ");
                int time = int.Parse(Console.ReadLine());
                math.StartMath(time);
                math.LastMessage();
            }
            // Quit
            else if (select == "5") {
                Console.WriteLine();
                Console.WriteLine("Thank you for your participation!");   
                end = true;             
            }
            // a else if the user prompt something else
            else {
                Console.WriteLine("Please insert a corect answer");
                end = false;
            }
            firstTime = true;
        }
    }
}
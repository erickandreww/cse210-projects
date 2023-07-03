using System;

class Program
{
    static void Main(string[] args)
    {
        List <string> menu = new List <string> 
            {"   1. Create New Goal","   2. List Goals", 
            "   3. Save Goals", "   4. Load Goals",
            "   5. Record Event", "   6. Quit"};
        List <string> secondMenu = new List <string> 
            {"   1. Simple Goal", "   2. Eternal Goal", "   3. Checklist Goal"};
        
        bool end = false;
        int points = 0;
        List<Goals> myGoals = new List<Goals>();
        
        while (end != true) 
        {
            Console.WriteLine($"\nYou have {points} points\n");
            Console.WriteLine("Menu Options");
            foreach (string men in menu) {Console.WriteLine(men);}
            Console.Write("Select a choise from the menu: ");
            string select = Console.ReadLine();
            if (select == "1") {
                foreach (string secMen in secondMenu) {Console.WriteLine(secMen);}
                Console.Write("Which Tipe of goal would you like to create? ");
                string goalSelect = Console.ReadLine();
                if (goalSelect == "1") {
                    Console.WriteLine("Simple Goal");

                    SimpleGoals simple = new SimpleGoals();
                    myGoals.Add(simple);
                }
                else if (goalSelect == "2") {
                    Console.WriteLine("Eternal Goal");

                    EternalGoals eternal = new EternalGoals();
                    myGoals.Add(eternal);
                }
                else if (goalSelect == "3") {
                    Console.WriteLine("Checklist Goal");

                    ChecklistGoals checkGoal = new ChecklistGoals();
                    myGoals.Add(checkGoal);
                }
            }
            else if (select == "2") {
                Console.WriteLine("The goals are:");
                for (int i = 0; i < myGoals.Count; i++) 
                {
                    string goal = myGoals[i].Display();
                    Console.WriteLine($"{i+1}. {goal}");
                }
            }
            else if (select == "3") {
                Console.WriteLine(3);
            }
            else if (select == "4") {
                Console.WriteLine(4);
            }
            else if (select == "5") {
                Console.WriteLine(5);
            }
            else if (select == "6") {
                Console.WriteLine();
                Console.WriteLine("quit");       
                end = true;         
            }
            else {
                Console.WriteLine("Please insert a corect answer");
                end = false;
            }
        }
    }
}

// the program class will take carry of the menu and save and load.
// the base class will take carry about the points, 
// each activity will have a class, and will save in a kind of list, maybe with $"";

// all the goals will have the different things, and all of the classes will need 
// to have a displayGoals, that will work to display acording to the type of the goal (class)
// 

// a save diference like, the simples is
// name, description, points, *bool
// Eternal: name, description, points
// Checklist: name, description, points, bonuspoints, times, actualtimes

// GetPoints module

// level up by completing goals



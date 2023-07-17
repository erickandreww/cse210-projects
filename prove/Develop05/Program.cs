using System;

class Program
{
    static void Main(string[] args)
    {
        // A list to show the menu
        List <string> menu = new List <string> 
            {"   1. Create New Goal","   2. List Goals", 
            "   3. Save Goals", "   4. Load Goals",
            "   5. Record Event", "   6. Quit"};
        List <string> secondMenu = new List <string> 
            {"   1. Simple Goal", "   2. Eternal Goal", "   3. Checklist Goal"};
        
        // variables for the loop, points and level
        bool end = false;
        int points = 0;
        string level = levelUp(points);
        List<Goals> myGoals = new List<Goals>();
        // while loop to run the menu
        while (end != true) 
        {
            Console.WriteLine($"\nYou have {points} points");
            Console.WriteLine($"Level: {level}\n");
            Console.WriteLine("Menu Options");
            foreach (string men in menu) {Console.WriteLine(men);}
            Console.Write("Select a choise from the menu: ");
            string select = Console.ReadLine();
            // menu to select the type of goal
            if (select == "1") {
                foreach (string secMen in secondMenu) {Console.WriteLine(secMen);}
                Console.WriteLine();
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
            // Print the goals list
            else if (select == "2") {
                Console.WriteLine();
                Console.WriteLine("The goals are:");
                for (int i = 0; i < myGoals.Count; i++) 
                {
                    string goal = myGoals[i].Display();
                    Console.WriteLine($"{i+1}. {goal}");
                }
            }
            // Save the goals
            else if (select == "3") {
                Console.Write("What is the Filename for the goal file? ");
                string filename = Console.ReadLine();
                Record save = new Record(myGoals, filename, points);
                save.Saving();
            }
            // Load the goals
            else if (select == "4") {
                Console.Write("What is the Filename for the goal file? ");
                string filename = Console.ReadLine();
                Record load = new Record(filename);
                myGoals = load.Loading();
                points = load.GetPoints();
            }
            // Record goals
            else if (select == "5") {
                int goalNumber;
                Console.WriteLine("The Goals are: ");
                for (int i = 0; i < myGoals.Count; i++) {
                    string goalName = myGoals[i].getName();
                    Console.WriteLine($"{i+1}. {goalName}");
                }
                Console.Write("Which goal did you accomplish? ");
                goalNumber = int.Parse(Console.ReadLine());

                if (goalNumber > myGoals.Count+1 || goalNumber == 0) {
                    Console.WriteLine("This goal does not exist");
                }
                else {
                    points += myGoals[goalNumber-1].Complete();
                    Console.WriteLine($"You now have {points} points.");
                }
            // Quit
            }
            else if (select == "6") {
                Console.WriteLine();      
                end = true;         
            }
            else {
                Console.WriteLine("Please insert a corect answer");
                end = false;
            }
            level = levelUp(points);
        }
    }

    // A method to cate of the levels
    public static string levelUp(int points) {
        List<string> levels = new List<string>{
            "Begginer", "Middle", "Advanced"
        };
        int upgrade = 500;
        string actualLevel = "";
        foreach (string level in levels) {
            if (points >= upgrade) 
            {
                upgrade += 500;
            }
            else if (points < upgrade) {
                actualLevel = level;
                break;
            }
        }
        return actualLevel;
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


// actual title/level: 
// level acording to how many activities the person completed, 
// or how many points they have
// levels will be here
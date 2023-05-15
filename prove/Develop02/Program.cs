using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        List<Entry> allEntry = new List<Entry>();
        // Introduction
        Console.WriteLine("Welcome to the Journal Program!");
        List <string> menu = new List <string> 
            {"1. Write", "2. Display", "3. Save", "4. Load", "5. Quit"}; 
        bool quit = false;
        while (quit != true) {
            // Menu Selection
            Console.WriteLine("Please select one of the following choises:");
            foreach (string men in menu) {
                Console.WriteLine(men);
            }
            Console.Write("What would you like to do? ");
            string choise = Console.ReadLine();
            // Main code
            if (choise == "1") {
                string question = PromptGenerator();
                Console.WriteLine(question);

                Entry entry = new Entry();
                entry._userPrompt = Console.ReadLine();
                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("dd MMMM yyyy");
                entry._data = formattedDateTime;
                entry._question = question;
                allEntry.Add(entry);
            }
            else if (choise == "2") {
                foreach (Entry e in allEntry)
                {
                    e.DisplayPrompt();
                    Console.WriteLine();
                }
            }
            else if (choise == "3") {
                SaveToFile(allEntry);
            }
            else if (choise == "4") {
                List<Entry> newAllEntry = ReadFromFile(); 
            }
            else if (choise == "5") {
                quit = true;                
            }
            else {
                Console.WriteLine("Please, insert a correct answer...");
                quit = false;
                quit = true;
            }

        }
    }

    static string PromptGenerator()
    {
        List <string> thoughtQuestion = new List<string> {
            "Who was the most interesting person I interacted with today?", 
            "What was the best part of my day?", 
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?", 
            "If I had one thing I could do over today, what would it be?"
        };
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);
        return thoughtQuestion[number];
    }

    public static void SaveToFile(List<Entry> allEntry)
    {
        Console.WriteLine("Saving to file...");
        string fileName = "test.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in allEntry)
            {
                outputFile.WriteLine($"Date: {e._data} - Prompt: {e._question}");
                outputFile.WriteLine($"{e._userPrompt}.");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {
        Console.WriteLine("Loading from file...");
        List<Entry> allEntry = new List<Entry>();
        string fileName = "test.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return allEntry;
    }
}


// promp 
// ask user text. 
// save his text. 

// display his texts that has been saved. 

// save his journal with a program name / or overwrite one with the same name.

// load a journal asking the program name

// quit the code.


// list of frases that will result in a prompt of the user

// someway to display the journal that the user is writing. 

// save the journay, the user will prompt a filename and will be creted a txt with
// this name or will replace a creted journal.txt.

// someway to load the txt.

// menu

// leave way
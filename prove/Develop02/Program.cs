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
                Console.Write("What is the filename? ");
                string filenameToSave = Console.ReadLine();
                SaveToFile(allEntry, filenameToSave);
            }
            else if (choise == "4") {
                Console.Write("What is the filename? ");
                string filenameToLoad = Console.ReadLine();
                allEntry = ReadFromFile(filenameToLoad); 
            }
            else if (choise == "5") {
                quit = true;                
            }
            else {
                Console.WriteLine("Please, insert a correct answer...");
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

    public static void SaveToFile(List<Entry> allEntry, string filename)
    {
        Console.WriteLine("Saving to file...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in allEntry)
            {
                outputFile.WriteLine($"{e._data},{e._question},{e._userPrompt}");
            }
        }
    }

    public static List<Entry> ReadFromFile(string filename)
    {
        Console.WriteLine("Loading from file...");
        List<Entry> allEntry = new List<Entry>();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newEntry = new Entry();
            newEntry._data = parts[0];
            newEntry._question = parts[1];
            newEntry._userPrompt = parts[2];

            allEntry.Add(newEntry);
        }

        return allEntry;
    }
}
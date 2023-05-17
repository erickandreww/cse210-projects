using System;
using System.Collections.Generic;
using System.IO; 
// journal class

public class journal
{
    string _filename;
    List<Entry> _entry;

    // a function that will save the file
    
    // public static void SaveToFile(List<Entry> allEntry, string filename)
    // {
    //     Console.WriteLine("Saving to file...");

    //     using (StreamWriter outputFile = new StreamWriter(filename))
    //     {
    //         foreach (Entry e in allEntry)
    //         {
    //             outputFile.WriteLine($"{e._data},{e._question},{e._userPrompt}");
    //         }
    //     }
    // }
    
    
    // a funtion that will load the file

    //     public static List<Entry> ReadFromFile(string filename)
    // {
    //     Console.WriteLine("Loading from file...");
    //     List<Entry> allEntry = new List<Entry>();

    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split(",");
    //         Entry newEntry = new Entry();
    //         newEntry._data = parts[0];
    //         newEntry._question = parts[1];
    //         newEntry._userPrompt = parts[2];

    //         allEntry.Add(newEntry);
    //     }

    //     return allEntry;
    // }
}

// Adding an entry
// Displaying all the entries
// Saving to a file
// Loading from a file
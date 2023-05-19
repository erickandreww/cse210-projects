using System;
using System.Collections.Generic;
using System.IO; 
// journal class

public class Journal
{
    public string _filename;
    public List<Entry> _entry;

    // a function that will save the file
    public void SaveToFile()
    {
        Console.WriteLine("Saving to file...");

        string csvFilename = _filename + ".csv";

        using (StreamWriter outputFile = new StreamWriter(csvFilename))
        {
            foreach (Entry e in _entry)
            {
                outputFile.WriteLine($"{e._data}|{e._question}|{e._userPrompt}");
            }
        }
    }
    
    // a funtion that will load the file

    public List<Entry> ReadFromFile()
    {
        Console.WriteLine("Loading from file...");
        List<Entry> _allEntry = new List<Entry>();

        string csvFilename = _filename + ".csv";

        string[] lines = System.IO.File.ReadAllLines(csvFilename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._data = parts[0];
            newEntry._question = parts[1];
            newEntry._userPrompt = parts[2];

            _allEntry.Add(newEntry);
        }

        return _allEntry;
    }

}
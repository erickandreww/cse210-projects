using System;

public class Entry 
{
    public string _userPrompt;
    public string _data;
    public string _question;
    public void DisplayPrompt()
    {
        Console.WriteLine($"Date: {_data} - Prompt: {_question}");
        Console.WriteLine($"{_userPrompt}.");
    }
}
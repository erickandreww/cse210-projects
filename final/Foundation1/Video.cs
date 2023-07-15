using System;

class Video 
{
    // variables to hold video informations 
    public string _title; 
    public string _description;
    public int _videoLenght;
    public List<List<string>> _commentsList = new List<List<string>>();

    // method to return the number of comments 
    public int numberComments()
    {
        return _commentsList.Count;
    }

    // method to display all video information
    public void Display() 
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Duration: {_videoLenght}");
        Console.WriteLine($"Number of Comments: {numberComments()}");
        foreach (List<string> comment in _commentsList) {
            Console.WriteLine($"{comment[0]}: \n\"{comment[1]}\".");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
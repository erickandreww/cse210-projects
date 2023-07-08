using System;

class Video 
{
    public string _title; 
    public string _description;
    public int _videoLenght;
    public List<List<string>> _commentsList = new List<List<string>>();

    public int numberComments()
    {
        return _commentsList.Count;
    }

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


// track the title, author, and length 
// (in seconds) of the video

// Each video also has responsibility to store
// a list of comments, and should have a method 
// to return the number of comments
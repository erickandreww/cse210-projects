using System;

class ListingActivity : Activity
{
    private int itemCount;
    private string _message;
    private List<string> _listingMessages = new List<string>();

    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    private void randomListingMessages() 
    {
        _listingMessages.Add("Who are people that you appreciate?");
        _listingMessages.Add("What are personal strengths of yours?");
        _listingMessages.Add("Who are people that you have helped this week?");
        _listingMessages.Add("When have you felt the Holy Ghost this month?");
        _listingMessages.Add("Who are some of your personal heroes?");

        Random rNumber = new Random();
        int number = rNumber.Next(_listingMessages.Count);

        _message = _listingMessages[number];
    }

    public void startListing(int time) 
    {
        _time = time;
        GetReady();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        randomListingMessages();
        Console.WriteLine($"--- {_message} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        countDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        Console.WriteLine();
        itemCount = 0;

        while ((DateTime.Now < endTime)) {
            Console.Write(" >");
            Console.ReadLine();
            itemCount ++;
        }
        Console.WriteLine();
        if (itemCount == 1) {
            Console.WriteLine($"You listed {itemCount} item!");
        }
        else {
            Console.WriteLine($"You listed {itemCount} items!");
        }
    }
}
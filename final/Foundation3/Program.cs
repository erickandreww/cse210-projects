//Regardless of the type, all events need to 
// have an Event Title, Description, Date, 
// Time, and Address.

using System;

class Program
{
        public static void Main(string[] args)
    {

        // Lecture Event
        List<string> lecture = new List<string>() {
            "Future of Tech: Innovation Unleashed", "Explore the latest technology trends with industry pioneers.", 
            "19 Ago 2023", "8:30pm", "123 Main St, Anytown, CA", "Adrian", "200"
        };

        Lectures lectureEvent = new Lectures(lecture[0], lecture[1], lecture[2], 
        lecture[3], lecture[4], lecture[5], lecture[6]);
        lectureEvent.Standard();
        Console.WriteLine();
        lectureEvent.Full();
        Console.WriteLine();
        lectureEvent.Short();
        Console.WriteLine("\n----------------------------------------\n");


        // Outdoor Gathering Event
        List<string> outdoor = new List<string>() {
            "Family Picnic in the Park", "Create cherished memories with a delightful park picnic.", 
            "22 Jul 2023", "10:00am", "456 Elm Ave, Springfield", 
            "Good news! The weather for our event is expected to be ideal."
        };

        Outdoor outdoorGatheringEvent = new Outdoor(outdoor[0], outdoor[1], 
        outdoor[2], outdoor[3], outdoor[4], outdoor[5]);

        outdoorGatheringEvent.Standard();
        Console.WriteLine();
        outdoorGatheringEvent.Full();
        Console.WriteLine();
        outdoorGatheringEvent.Short();
        Console.WriteLine("\n----------------------------------------\n");


        // Reception Event
        List<string> reception = new List<string>() {
            "Networking Soiree: Igniting Opportunities", "Connect with professionals from diverse industries and unlock exciting possibilities.", 
            "28 Jul 2023", "9:00pm", "789 Oak Rd, Lakeside, TX", "info@stellar-events.com"
        };

        Receptions receptionEvent = new Receptions(reception[0], reception[1],
        reception[2], reception[3], reception[4], reception[5]);
        receptionEvent.Standard();
        Console.WriteLine();
        receptionEvent.Full();
        Console.WriteLine();
        receptionEvent.Short();
        Console.WriteLine();
    }
}
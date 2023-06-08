using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Clear();
        // call reference class
        Reference refer = new Reference();
        string reference = refer.GetReference();
        // call scripture class
        Scripture scrp = new Scripture(reference);
        string scripture = scrp.GetScripture();
        // Show the scripture
        Console.WriteLine($"{reference} {scripture}.");
        Console.WriteLine();
        // Ask user prompt
        Console.Write("Press enter to continue or type quit to finish: ");
        string userPrompt = Console.ReadLine();
        Console.WriteLine();
        // some booleans values
        bool erased = false;
        bool finish = false; 
        int count = 0;
        // while loop
        while (finish == false && count < 4) {
            // call the word class and hide some words from the scripture
            if (userPrompt == "") {
                Console.Clear();
                Words word = new Words(scripture);
                scripture = word.HideRandomWords(count);
                Console.WriteLine($"{reference} {scripture}.");
                Console.WriteLine();
                erased = true;
                count += 1;
            }
            // if the user wants to quit the program
            else if (userPrompt == "quit") {
                finish = true; 
                break;
            }
            // if the user enter something else that was not requested.
            else {
                Console.WriteLine("Please insert a correct answer");
                finish = false;
            }
            // some things to continue the program
            // ask again the user prompt
            Console.Write("Press enter to continue or type quit to finish: ");
            userPrompt = Console.ReadLine();
            Console.WriteLine();
            // checks whether the program passed by the word class or not
            if (erased == true) {
                Console.Clear();
            }
            erased = false;
        }
    }
}

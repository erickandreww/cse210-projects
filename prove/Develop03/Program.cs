using System;

class Program 
{
    static void Main(string[] args)
    {
        Console.Clear();
        // call scripture class
        Scripture scrp = new Scripture();
        string scripture = scrp.GetScripture();
        // call referece class
        Reference refer = new Reference();
        string reference = refer.GetReference();
        // Show the scripture
        Console.WriteLine($"{reference} {scripture}");
        Console.WriteLine();
        // Ask user prompt
        Console.Write("Press enter to continue or type quit to finish: ");
        string userPrompt = Console.ReadLine();
        Console.WriteLine();

        bool finish = false; 
        while (finish == false) {
            if (userPrompt == "") {
                Console.WriteLine($"{reference} {scripture}");
                Console.WriteLine();
            }
            else if (userPrompt == "quit") {
                finish = true; 
                break;
            }
            else {
                Console.WriteLine("Please insert a correct answer");
                finish = false;
            }
            Console.Write("Press enter to continue or type quit to finish: ");
            userPrompt = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
        }
    }
}

// the program will only call, get prompt from 
// the user and show things;
// Also will clear the console

// The main program will
// 1. clear the console
// 2. call the reference and scripture and show both. 
// or just call the scriture that will call the reference by itself and return the text.
// 3. will ask a prompt from the user to enter: "quit" to quit or enter to continue.
// Enter: will clear the console. 
// a varaiable that will Call the words class and the words class will return the same scritpture 
// but with some random words erased of it.
// show the scripture and reapeat the process until don't have any words on the scripture.
// 

// Quit, finish the program. 

// The scripture class will call reference class and get the reference

// maybe tips for words
// turn the scripure in a list and return the list with some erased letters
// a function that will erase some letter from the list
// return the list and the program will change to a string
// when returned will calculate if have any "_" (underline) to see if erase or not.

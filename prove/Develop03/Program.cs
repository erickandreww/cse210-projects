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
        Console.WriteLine($"{reference} {scripture}.");
        Console.WriteLine();
        // Ask user prompt
        Console.Write("Press enter to continue or type quit to finish: ");
        string userPrompt = Console.ReadLine();
        Console.WriteLine();
        bool erased = false;
        bool finish = false; 
        int count = 0;
        while (finish == false && count < 6) {
            if (userPrompt == "") {
                Console.Clear();
                Words word = new Words();
                string newScripture = word.HideRandomWords(scripture);
                scripture = newScripture;
                Console.WriteLine($"{reference} {scripture}.");
                Console.WriteLine();
                erased = true;
                count += 1;
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
            if (erased == true) {
                Console.Clear();
            }
            erased = false;
        }
    }
}

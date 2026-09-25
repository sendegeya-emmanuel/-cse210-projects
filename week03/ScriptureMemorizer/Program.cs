using System;

// Student Name: Emmanuel Sendegeya
// Course: CSE 210 - BYU-Idaho
// Exceeding Requirements: I updated the program so that the random picker only selects words that are not already hidden. This makes the memorization process faster and avoids repeating hidden words.

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths";
        
        Scripture scripture = new Scripture(reference, text);
        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words, or type 'quit' to close:");
            
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Great! You have memorized the entire scripture.");
        }
    }
}
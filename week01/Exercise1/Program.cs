using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // 2. Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // 3. Display the text back all on one line precisely
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
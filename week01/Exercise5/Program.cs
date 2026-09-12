using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the functions step by step and save their values
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    // 1. Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. Function to ask and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // 3. Function to ask and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string response = Console.ReadLine();
        int number = int.Parse(response);
        return number;
    }

    // 4. Function to square a number and return the result
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // 5. Function to display the final result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
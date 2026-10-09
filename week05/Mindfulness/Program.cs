using System;

// =======================================================================================
// SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS REPORT:
// 1. Added the third core functionality: The Listing Activity tracking framework.
// 2. Implemented an enhanced countdown visualization system inside character boundaries.
// 3. Encapsulated clean, non-duplicating inheritance structures for all derived classes.
// =======================================================================================

public class Program
{
    public static void Main(string[] args)
    {
        string userChoice = "";

        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (userChoice == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (userChoice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }

        Console.Clear();
        Console.WriteLine("Thank you for practicing mindfulness today. Finish Strong!");
    }
}
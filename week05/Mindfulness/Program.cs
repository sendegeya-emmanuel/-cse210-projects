using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("Mindfulness Program Design Stubs Check");
        Console.WriteLine("========================================");

        // Instantiating the activities to verify the compilation and inheritance links
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        // Testing the inherited base display behaviors
        breathing.DisplayStartingMessage();
        Console.WriteLine();
        breathing.DisplayEndingMessage();

        Console.WriteLine("\n[System Check]: All OOP design stubs compiled successfully!");
    }
}
using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    // Base constructor requiring parameters for configuration consistency
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 30; // Default standard value
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    public void ShowSpinner(int seconds)
    {
        // Empty stub body for character iteration layout
    }

    public void ShowCountDown(int seconds)
    {
        // Empty stub body for countdown loops
    }

    // Public getter to share duration metric with child run processes
    public int GetDuration()
    {
        return _duration;
    }
}
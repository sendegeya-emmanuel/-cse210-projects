using System;

public class BreathingActivity : Activity
{
    // The constructor calls the base class constructor using 'base'
    public BreathingActivity() 
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        // Specific custom behavior that can call base methods like ShowCountDown()
    }
}
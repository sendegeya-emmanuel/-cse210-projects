using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Test 1: Simple Base Assignment
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine(); // Blank line for readable console output

        // Test 2: Math Assignment
        MathAssignment mathHomework = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());
        Console.WriteLine();

        // Test 3: Writing Assignment
        WritingAssignment writingHomework = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingHomework.GetSummary());
        Console.WriteLine(writingHomework.GetWritingInformation());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Ask the user for their grade percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        // 2. Determine the letter grade
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 3. Stretch Challenge: Determine the sign (+ or -)
        string sign = "";
        int lastDigit = percent % 10; // Gukoresha % 10 nk'uko mwarimu yabitanze nk'ihame (remainder)

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle exceptional cases (No A+, No F+, No F-)
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        // 4. Display the complete grade once
        Console.WriteLine($"Your grade is: {letter}{sign}");
        
        // 5. Check if the user passed the class
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Keep trying! You will do better next time!");
        }
    }
}
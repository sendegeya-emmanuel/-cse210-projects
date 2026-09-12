using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int userNumber = -1;
        
        // 1. Loop to get numbers from the user until they enter 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            
            // Only add the number to the list if it is NOT 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // 2. Core Requirements: Compute Sum, Average, and Max
        int sum = 0;
        int max = -999999; // Start with a very low number to find the max

        foreach (int number in numbers)
        {
            sum += number; // Add each number to the total sum
            
            if (number > max)
            {
                max = number; // Update max if the current number is larger
            }
        }

        // Compute average (use double to get decimal places)
        double average = (double)sum / numbers.Count;

        // 3. Display the results precisely
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
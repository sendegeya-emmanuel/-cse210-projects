using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable to keep track if the user wants to play the whole game again
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // 1. Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0; // Variable to count the number of guesses

            // 2. Loop until the user guesses the correct number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                guess = int.Parse(answer);
                guessCount++; // Increment the count by 1 each time

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // 3. Stretch Challenge: Ask the user if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thank you for playing! Goodbye.");
    }
}
using System;

namespace intro_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = 1;
            int upperBound = 1000;
            bool foundAnswer = false;
            int numOfTries = 0;
            int guess;

            // Prompt user for a number
            Console.WriteLine($"Pick a number between {lowerBound} and {upperBound}...");
            // Store the response
            var userInput = int.Parse(Console.ReadLine());

            while (foundAnswer == false) 
            {
                // Create guess and round up if float
                guess = (lowerBound + upperBound) / 2;

                // If the guess is equal to the userInput, exit the program
                if (guess == userInput)
                {
                    // Make sure the program exits with at least one try
                    if (numOfTries == 0) {
                        numOfTries = 1;
                    }

                    // If numOfTries is 1, use the word try
                    if (numOfTries == 1) {
                        Console.WriteLine($"The answer is {guess}, I got the answer in {numOfTries} try!");
                        foundAnswer = true;
                        break;
                    }
                    // Else, use the word tries
                    else
                    {
                        Console.WriteLine($"The answer is {guess}, I got the answer in {numOfTries} tries!");
                        foundAnswer = true;
                        break;              
                    }
                }

                // Ask user where the guess was in comparison to the actual answer
                Console.WriteLine($"Is the correct number higher, lower, or equal to {guess}?");
                // Store the response
                var result = Console.ReadLine();

                if (result.Contains("higher"))
                {
                    // Set new lower bound to be the previous guess to cut the problem in half
                    lowerBound = guess;
                    numOfTries++;
                }
                else if (result.Contains("lower"))
                {
                    // Set new upper bound to be the previous guess to cut the problem in half
                    upperBound = guess;
                    numOfTries++;
                }
            }
        }
    }
}

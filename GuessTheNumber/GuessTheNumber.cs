using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
       
            int theNumber = new Random().Next(10);
            bool keepGoing = true;
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name} I am thinking of a number between 1 and 10. Can you guess the number?");
            Console.WriteLine("Enter your guess, or enter -1 to exit.");
            int guessNum = 1;
            int guessCount = 1;
            do
            { 
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();

               
                bool result = Int32.TryParse(theGuess, out guessNum);

     
                if (!result)
                {
                    Console.WriteLine($"Sorry, {name}, that wasn't the number.");
                }
                else
                {
                    // If they enter a -1 then they want to exit the game
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"The number was {theNumber}, goodbye.");
                        keepGoing = false;
                    }
                    else
                    {
                        // Increase the guess count
                        guessCount++;

                        // If they got it right, tell them the guess count and exit
                        if (guessNum == theNumber)
                        {
                            Console.WriteLine($"{name}, you got it in {guessCount} guesses. Great job!");
                            keepGoing = false;
                        }
                        else
                        {
                            // Tell them to either guess lower or higher than the previous guess
                            Console.WriteLine("No, try {0}", guessNum < theNumber ? "guessing a higher number." : "guessing a lower number.");
                        }
                    }
                }
            } while (keepGoing);
        }
    }
}


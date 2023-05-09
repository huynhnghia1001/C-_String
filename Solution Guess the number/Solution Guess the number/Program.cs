using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int theNumber = new Random().Next(20);
            bool keepGoing = true;

            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thingking  of a number  between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            int guessNum = 0;
            int guessCount = 0;
            do 
            {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();

                bool result = Int32.TryParse(theGuess, out guessNum);

                if (!result)
                {
                    Console.WriteLine("Hmm, that doesn't look like a number. Try again.");
                }
                else
                {
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"Oh well. i was thingking of {theNumber}");
                        keepGoing = false;
                    }
                    else
                    {
                        guessCount++;
                        if(guessNum == theNumber)
                        {
                            Console.WriteLine($"You got it in {guessCount} guesses!!");
                            keepGoing = false;
                        }
                        else
                        {
                            Console.WriteLine("Node, {0} than that.", guessNum < theNumber ? "hight" : "lower");
                        }
                    }
                }

            } while (keepGoing);
        }
    }
}

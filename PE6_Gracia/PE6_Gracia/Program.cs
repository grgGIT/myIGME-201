using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_Gracia
{
    internal class Program
    {
        // Author: Geoff Gracia
        // Purpose: Creating a simple number guessing
        // Restrictions: Has to generate a guess using a random inclusive number 
        static void Main(string[] args)
        {
            // Method: Main
            // Purpose:  where all of this code will occur  
            // Restrictions: None


            //creating rndm obj and saving its value, then displaying at top of console for testing
            Random rnd = new Random();

            int randNum =  rnd.Next(0,101);

            Console.WriteLine("This is the random number for testing purposes: " + randNum);
            Console.WriteLine();

            //have indexer start at 1 so the number can be displayed for the turn number
            for (int i = 1; i < 9; i++)
            {
                
               
                //try catch to colllect any exceptions at all
                try
                {
                    //prompt and read. then parse read
                    Console.Write("Guess the value of a mystery number that is between 0 and 100: ");
                    string UserRead = Console.ReadLine();
                    int userGuess = int.Parse(UserRead);

                    Console.WriteLine();

                    //ends game if correctly guessed
                    if (userGuess == randNum)
                    {
                        Console.WriteLine("You're Correct!");
                        Console.WriteLine("Thanks for playing!");
                        Environment.Exit(0);
                    }
                    //continues game and lets the user know the guess was high 
                    else if (userGuess > randNum)
                    {
                        Console.WriteLine("Oo nice try! You were too high");

                    }
                    //continues game and lets the user know the guess was high 
                    else if (userGuess < randNum)
                    {
                        Console.WriteLine("Oo nice try! You were too low");
                    }
                }
                //catch sequence that just says try again
                catch (Exception e)
                {
                    Console.WriteLine("Invalid guess. Please try again by entering numbers 0 - 100!");
                }
                
               //turn counting 
                Console.WriteLine("turn {0}/8", i);
                Console.WriteLine();

                //tells them they can't play after turn 8
                if (i == 8)
                {
                    Console.WriteLine("It looks like you're out of tries. Please restart and try again! Bye :)");
                    Console.WriteLine();
                }
            }

        }
    }
}

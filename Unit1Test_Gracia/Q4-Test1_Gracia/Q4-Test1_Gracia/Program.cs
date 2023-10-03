using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Test1_Gracia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playAgain;

            Console.Write("Wanna play this game? (yes/no): ");
            playAgain = Console.ReadLine().Trim().ToLower();
            if (playAgain == "no")
            {
                Console.WriteLine("goodbye!");
                Environment.Exit(0);

            }
            else if (playAgain == "yes")
            {

            }
            else
            {
                Console.Write("Wanna play this game? ANSWER YES OR ELSE THE GAME ENDS (yes/no): ");
                playAgain = Console.ReadLine().Trim().ToLower();
            }
           
            Console.WriteLine();

            do 
            {

            
            //prompt
            Console.Write("Choose your question (1-3): ");
            string readEnter = Console.ReadLine();
            int parseEnter = int.Parse(readEnter);

            //reading 1 2 and 3 
            
            if (readEnter == "1")
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.Write("What is your favorite color? ");
                string choiceRead = Console.ReadLine().Trim().ToLower();
                if (choiceRead == "black")
                {
                        Console.WriteLine("Well done!");
                }

            
                else
                {
                        Console.WriteLine("Sorry that's incorrect...");
                        Console.WriteLine("The answer is: black, ");
                }

                //number 2
            }
            else if (readEnter == "2")
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.Write("What is the answer to life, the universe and everything?: ");
                string choiceRead = Console.ReadLine().Trim();
                if (choiceRead == "42")
                {
                    Console.WriteLine("Well Done!");
                }

                else
                {
                        Console.WriteLine("Sorry that's incorrect...");
                        Console.WriteLine("The answer is: 42, ");
                }

            }

            //number 3
            else if (readEnter == "3")
            {
                
                    Console.WriteLine("You have 5 seconds to answer the following question: ");
                    Console.Write("What is the airspeed velocity of an unladen swallow?: ");
                    Console.WriteLine();
                    string choiceRead = Console.ReadLine().Trim().ToLower();
                    if (choiceRead == "what do you mean? african or european swallow?")
                    {
                        Console.WriteLine("Well Done!");
                    }
                    else
                {
                    Console.WriteLine("Sorry that's incorrect...");
                    Console.WriteLine("The answer is: What do you mean? African or European swallow?");
                }

            }
            Console.WriteLine();
                Console.Write("Play Again? (yes/no) ");
                playAgain = Console.ReadLine().Trim().ToLower();
               
                    if (playAgain == "no")
                    {
                        Console.WriteLine("goodbye!");
                        Environment.Exit(0);
                    }

                do
                {
                    Console.Write("Play Again? (yes/no) ");
                    playAgain = Console.ReadLine().Trim().ToLower();
                   
                        if (playAgain == "no")
                        {
                            Console.WriteLine("goodbye!");
                            Environment.Exit(0);
                        }
                } while (playAgain != "yes");

                Console.WriteLine();
                
        }while (playAgain == "yes");

        }
    }
}


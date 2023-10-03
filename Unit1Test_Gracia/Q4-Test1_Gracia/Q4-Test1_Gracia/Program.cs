using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Q4_Test1_Gracia
{
    internal class Program
    {
        //Author: Geoff Gracia 
        //purpose recreate 3 questions app
        //limits: stay within what the app template is

        //for the timer
        private static Timer timer;
        private static bool timeOver;

        static void Main(string[] args)
        {
            //globals
            string playAgain;
            //5 seconds
            Program.timer = new Timer(5000.0);
            //throws my method
            Program.timer.Elapsed += new ElapsedEventHandler(Program.EndOfLine);

            //prompt to start
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
                Console.Write("Wanna play this game? Hint: ANSWER YES OR ELSE THE GAME ENDS (yes/no): ");
                playAgain = Console.ReadLine().Trim().ToLower();
            }
           
            Console.WriteLine();

            //do-while for the whole program
            do 
            {

            
            //prompt
            Console.Write("Choose your question (1-3): ");
            string readEnter = Console.ReadLine();
            int parseEnter = int.Parse(readEnter);

                //reading 1 2 and 3 and then using it to pop up each individual prompt

                //for time useage
                timeOver = false;

                if (readEnter == "1")
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.Write("What is your favorite color? ");
                timer.Start();
                string choiceRead = Console.ReadLine().Trim().ToLower();
                timer.Stop();
                    if (choiceRead == "black")
                {
                        Console.WriteLine("Well done!");
                }

            
                else
                {
                        Console.WriteLine("Sorry you were incorrect...");
                        Console.WriteLine("The answer is: black, ");
                }

                //number 2
            }
            else if (readEnter == "2")
            {
                Console.WriteLine("You have 5 seconds to answer the following question: ");
                Console.Write("What is the answer to life, the universe and everything?: ");
                timer.Start();
                string choiceRead = Console.ReadLine().Trim();
                timer.Stop();
              if (choiceRead == "42")
                {
                    Console.WriteLine("Well Done!");
                }

                else
                {
                        Console.WriteLine("Sorry you were incorrect...");
                        Console.WriteLine("The answer is: 42, ");
                }

            }

            //number 3
            else if (readEnter == "3")
            {
                
                    Console.WriteLine("You have 5 seconds to answer the following question: ");
                    Console.Write("What is the airspeed velocity of an unladen swallow?: ");
                    timer.Start();
                    string choiceRead = Console.ReadLine().Trim().ToLower();
                    timer.Stop();
                    if (choiceRead == "what do you mean? african or european swallow?")
                    {
                        Console.WriteLine("Well Done!");
                    }
                    else
                {
                    Console.WriteLine("Sorry you were incorrect...");
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
        //timer method 
        private static void EndOfLine(object sender, ElapsedEventArgs e)
        {
            Program.timer.Stop();
            Console.WriteLine("Time's up! Please press enter...");
            Console.WriteLine();
            Program.timeOver = true;
        }
    }
}


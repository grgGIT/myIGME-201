using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PE7_Gracia
{
    internal class Program
    {
        // Author: Geoff Gracia
        // Purpose: Creating a mad libs from external text files
        // Restrictions: Using Text.IO
        static void Main(string[] args)
        {
            // Method: Main
            // Purpose:  where all of this code will occur  
            // Restrictions: None


            //creating a ref variable for the file 
            //creating an array for each word
            string fileName = "C:\\Users\\Geoffrey Gracia\\source\\repos\\myIGME-201\\PE7_Gracia\\PE7_Gracia\\templates\\MadLibsTemplate.txt";
            string[] madLibArr;
            //madlib array that saves the split method and the text gets read into a file ref string var
            string savedTextFromFile = File.ReadAllText(fileName);
            madLibArr = savedTextFromFile.Split();
            string resultString;


            //beginning prompt 
            Console.Write("Hello! Welcome to Mad Libs! Would you like to play?");
            string userYN = Console.ReadLine().ToLower().Trim();
            
            while (userYN != "yes")
            {
                if (userYN == "yes")
                {
                    Console.WriteLine("Great! Have fun!");
                    Console.WriteLine();
                }
                else if (userYN == "no")
                {
                    Console.WriteLine("Well it's sad to see you go... goodbye!");
                   Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("sorry can you answer again?");
                    Console.WriteLine();
                    Console.Write("Hello! Welcome to Mad Libs! Would you like to play?");
                    userYN = Console.ReadLine().ToLower().Trim();
                }
            }
           


            //prompt for name
            Console.Write("What is your name? ");
            string plyrName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("{0} is a great name!", plyrName);
            Console.WriteLine();



            //for finding \n and {}
            foreach (string word in madLibArr)
            {
                Console.WriteLine(word);

                if (word == "\n")
                {
                    word.Remove(word.Length - 1);
                }

                char charFinder = char.Parse(word);

                if (charFinder == '{')
                {
                    //string.replace 
                    Console.Write("Please write a response for this prompt: {0}", word);
                    string savedAnswer = Console.ReadLine();
                    word.Remove(word.Length - 1);
                    word.Replace(word, savedAnswer);
                }
            }

            //story choice and displaying the full sentences 
            try
            {
                Console.WriteLine("Which Story would you like to choose out of 1 - 6");
                string storyEntry = Console.ReadLine();
                madLibArr = savedTextFromFile.Split('.');
                if (storyEntry == "1")
                {
                    Console.WriteLine(madLibArr[0] + ".");
                }
                else if (storyEntry == "2")
                {
                    Console.WriteLine(madLibArr[1] + ".");
                }
                else if (storyEntry == "3")
                {
                    Console.WriteLine(madLibArr[2] + ".");
                }
                else if (storyEntry == "4")
                {
                    Console.WriteLine(madLibArr[3] + ".");
                }
                else if (storyEntry == "5")
                {
                    Console.WriteLine(madLibArr[4] + ".");
                }
                else if (storyEntry == "6")
                {
                    Console.WriteLine(madLibArr[5] + ".");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

        }
        
        }
    }

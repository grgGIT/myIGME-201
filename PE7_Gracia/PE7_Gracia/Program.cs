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

            //beginning prompt 
            Console.Write("Hello! Welcome to Mad Libs! Would you like to play?");
            string userYN = Console.ReadLine().ToLower().Trim();

            if(userYN == "yes")
            {
                Console.WriteLine("Great! Have fun!");
                Console.WriteLine();
            }
            else if(userYN == "no")
            {
                Console.WriteLine("Hmmmm well this game is super fun so I am going to ask you AGAIN if you would like to play (hint: the answer is yes)");
                Console.WriteLine();
                Console.Write("Hello! Welcome to Mad Libs! Would you like to play?");
                userYN = Console.ReadLine().ToLower().Trim();
            }
            else
            {
                Console.WriteLine("sorry can you answer again?");
                Console.WriteLine();
                Console.Write("Hello! Welcome to Mad Libs! Would you like to play?");
                 userYN = Console.ReadLine().ToLower().Trim();
            }

            //creating a ref variable for the file 
            //creating an array for each word
            string  fileName = "C:\\Users\\Geoffrey Gracia\\source\\repos\\myIGME-201\\PE7_Gracia\\PE7_Gracia\\templates\\MadLibsTemplate.txt";
            string[] madLibArr;

            //prompt for name
            Console.Write("What is your name? ");
            string plyrName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("{0} is a great name!", plyrName);
            Console.WriteLine();

            /*
           try
            {
                Console.WriteLine("Which Story would you like to choose 1 or N?");
                string entry = Console.ReadLine();
                if (entry == "1")
                {

                }
                else if (entry == "N")
                {

                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            */

         string savedTextFromFile  = File.ReadAllText(fileName);
         madLibArr = savedTextFromFile.Split();


            //for my own testing
            foreach (string word in madLibArr)
            {
                
                Console.WriteLine(word );
                
                
            }
         //string.replace 


       

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14_Test1_UT1_BugSquash_Gracia
{
    internal class Program
    {
        //Author: Geoff - from given code
        // fix broken code
        //limits: keep all code the same, just fix broken
          
        static void Main(string[] args)
        {
            // Calculate x^y for y > 0 using a recursive function

            //removed duplicate Main 
            
                string sNumber;
                int nX;
            //added semicolon
            int nY;
            //chnaged nAnswer to a double
                double nAnswer;

            //added quotes
                Console.WriteLine("This program calculates x ^ y.");

                do
                {
                    Console.Write("Enter a whole number for x: ");
                //made sNumber equal to readline
                    sNumber =Console.ReadLine();
                } while (!int.TryParse(sNumber, out nX));

                do
                {
                    Console.Write("Enter a positive whole number for y: ");
                    sNumber = Console.ReadLine();
                //changed doWhile loop conditions for y (making it out nY not nX)
                } while (int.TryParse(sNumber, out nY));

                // compute the exponent of the number using a recursive function

            //fixed Power to be Math.Pow
                nAnswer = Math.Pow(nX, nY);

                Console.WriteLine("{nX}^{nY} = {nAnswer}");
            


            

            }
        }
}

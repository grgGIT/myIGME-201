using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gracia_PE2
{
   
        // Author: Geoff Gracia
        // Purpose: Bug squashing exercise
        // Restrictions: None
        class Program
        {
            // Method: Main
            // Purpose: Loop through the numbers 1 through 10 
            // Output N/(N-1) for all 10 numbers
            // and list all numbers processed
            // Restrictions: None

            static void Main(string[] args)
            {
            // declare int counter

            ///
            // int i was missing its semicolon, which means it was a syntax error
            ///

            int i =0;

            // loop through the numbers 1 through 10
 for (i = 1; i < 10; i++)
                {
                    // declare string to hold all numbers
                    string allNumbers;
                // output explanation of calculation

                ///
                // int i is not a string and cannot be used interchangably as a string variable, therefore it was a logical error
                ///

                Console.WriteLine("{0} / {1} = ??", i, i - 1);

                // og ~ ( i + "/" + i - 1 + " = ")


                ///
                //DivideByZeroException occured for the calculation once running, therefore there is a runtime error
                ///

                //created variable for the calculations to occur 
                int result = i - 1;
               
                string calcAnsw = result.ToString();
                    

                // output the calculation based on the numbers

                

                Console.WriteLine("answer: "+ calcAnsw );
                    // concatenate each number to allNumbers
                    allNumbers = result.ToString();


                ///
                //allNumbers was being used outside of the scope of the for loop, so it was a runtime error 
                ///

                // output all numbers which have been processed

                Console.WriteLine("These numbers have been processed: ", allNumbers);
                Console.WriteLine();

                // increment the counter
                i = i + 1;

            }
                

 
            }
        }
    }

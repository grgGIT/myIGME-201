using System;

namespace PE4_Q_oneTwo_Gracia

{
    // Author: Geoff Gracia
    // Purpose:PE 4 reading and utilizing user prompt for a truth table question 2 
    // Restrictions: None

    internal class Program
    {
        // Method: Main
        // Purpose: Take user input to create a boolean truth table and display final truth value
        // Output: final truth value
        // Restrictions: None

        static void Main(string[] args)
        {


            /* operand1	operand2	result
false		false		false
false		true		true
true		false		true
true		true		false
*/
            ///
            //Question 2 
            ///

            //directions 
            Console.WriteLine("Please make sure only ONE variable is greater than 10 and the other should be less than 10.");

            //first prompt for first value and reading it
            Console.Write("Enter value for Var1: ");
            string read1 = Console.ReadLine();
            double var1 = double.Parse(read1);
            Console.WriteLine();
            //second prompt for 2nd value and reading and saving as well
            Console.Write("Enter Value for Var2: ");
            string read2= Console.ReadLine();
            double var2 = double.Parse(read2);
            Console.WriteLine();

            //conditional to repeat the prompt if there is incorrect input of both being greater than 10
            if (var1 > 10 && var2 >10)
            {
                Console.WriteLine("Invalid choices. Again, please make sure ONLY ONE variable is greater than 10 (the OTHER SHOULD BE LESS than 10)");
                Console.WriteLine();
                Console.Write("Enter value for Var1: ");
                read1 = Console.ReadLine();
                var1 = double.Parse(read1);
                Console.WriteLine();
                Console.Write("Enter Value for Var2");
                read2 = Console.ReadLine();
                var2 = double.Parse(read2);
            }
           
            //boolean value
            bool checkValue;
            //checks for the specific case of having one var that is less than 10 and one that is greater than 10 
            if (var1 > 10 ^ var2  > 10 || var1 < 10 ^ var2 < 10)
            {
                checkValue = true;
                
            }

            else
            {
                checkValue = false;
            }

            //print final truth value
            Console.WriteLine("The final truth value of both is: {0} ", checkValue);
        


            



        }
    }
}

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
            Console.WriteLine("Please make sure only ONE variable is greater than 10 and the other should be less than 10.");

            Console.Write("Enter value for Var1: ");
            string read1 = Console.ReadLine();
            int var1 = int.Parse(read1);
            Console.WriteLine();
            Console.Write("Enter Value for Var2: ");
            string read2= Console.ReadLine();
            int var2 = int.Parse(read2);
            Console.WriteLine("");

            if (var1 > 10 && var2 >10)
            {
                Console.WriteLine("Invalid choices. Again, please make sure ONLY ONE variable is greater than 10 (the OTHER SHOULD BE LESS than 10)");
                Console.WriteLine();
                Console.Write("Enter value for Var1: ");
                read1 = Console.ReadLine();
                var1 = int.Parse(read1);
                Console.WriteLine();
                Console.Write("Enter Value for Var2");
                read2 = Console.ReadLine();
                var2 = int.Parse(read2);
            }
           

            bool checkValue;
            if (var1 > 10 ^ var2  > 10 || var1 < 10 ^ var2 < 10)
            {
                checkValue = true;
                
            }

            else
            {
                checkValue = false;
            }

            Console.WriteLine("The final truth value of both is: {0} ", checkValue);
        


            



        }
    }
}

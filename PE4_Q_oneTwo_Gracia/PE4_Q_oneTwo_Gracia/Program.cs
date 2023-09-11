using System;

namespace PE4_Q_oneTwo_Gracia
{
    internal class Program
    {
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
            int var1 = Console.Read();
            Console.WriteLine();
            Console.Write("Enter Value for Var2");
            int var2= Console.Read();

            if (var1 > 10 && var2 >10)
            {
                Console.WriteLine("Invalid choices. Again, please make sure ONLY ONE variable is greater than 10 (the OTHER SHOULD BE LESS than 10)");
            }
           

            bool checkValue;
            if (var1 > 10 ^ var2  > 10)
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

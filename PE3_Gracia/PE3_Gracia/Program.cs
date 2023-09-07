using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE3_Gracia
{
    // Author: Geoff Gracia
    // Purpose: Given code demonstrations and answers for PE3 doc
    // Restrictions: None

    internal class Program
    {
        // Method: Main
        // Purpose: Solve question 5 and any others that require demo code 
        // Restrictions: None

        static void Main(string[] args)
        {
           

            ///
            // question 8
            ///


            int num1 = 2;

            int num2 = 4;

            int num3 = 5;

            num1 = num1 * num3;

            num2 = num1 / num2;

            num3 = num3 % num2;
            Console.WriteLine(num1);
            Console.WriteLine(num2);    
            Console.WriteLine(num3);

            Console.WriteLine();

            ///
            // question 7
            ///

            double num4 = (6 / 4.0 + 3.5) / 2;
           
            Console.WriteLine(num4);

            ///
            // question 5
            ///

            //separator 
            Console.WriteLine("-------");
            Console.WriteLine("For Question 5 ");
            Console.WriteLine("-------");
            Console.WriteLine();

            //prompt 1 read and convert
            Console.Write("Enter a number: ");
            string numread1 = Console.ReadLine();
            int numConv1 = Convert.ToInt32(numread1);
            Console.WriteLine();

            //prompt 2 read and convert
            Console.Write("Enter a second number: ");
            string numread2 = Console.ReadLine();
            int numConv2 = Convert.ToInt32(numread2);
            Console.WriteLine();

            //prompt 3 read and convert
            Console.Write("Enter a third number: ");
            string numread3 = Console.ReadLine();
            int numConv3 = Convert.ToInt32(numread3);
            Console.WriteLine();

            //prompt 4 read and convert
            Console.Write("Enter a fourth number: ");
            string numread4 = Console.ReadLine();
            int numConv4 = Convert.ToInt32(numread4);
            Console.WriteLine();

            //int array to hold the converted nums 
            int[] numArray = { numConv1, numConv2, numConv3, numConv4 };
            //separating the array indexes with commas
            string seperatedArr = String.Join(",", numArray);
            //printing the comma array
            Console.WriteLine(seperatedArr);

            Console.WriteLine("----------- End Question 5  -----------");
            Console.WriteLine();

            ///
            // question 14
            ///

            Console.WriteLine("Please type your name below. ");
            string nameGiven = Console.ReadLine();
            Console.WriteLine("Your name is {0}", nameGiven);

           

            ///
            //question 15
            ///

            string myName = "Geoff";
            string lastName = " Gracia";
            myName = myName + lastName;
            Console.WriteLine(myName);


            Console.WriteLine();


            ///
            //question 12 & 13
            ///

            Console.Write("Hi there");

            Console.Write("David");

            Console.WriteLine();

            Console.Out.WriteLine("50 plus 25 is " + 50 + 25);

        }
    }
}

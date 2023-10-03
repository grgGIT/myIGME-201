using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Test1_Gracia
{
    internal class Program
    {
        //Author: Geoff Gracia 
        // to create an impersation delegate for Math.Round
        //Limits: none 

        //delegate 
        public delegate void ImRounding(double num1, int num2);

        //class for methods for delegate to reference
        public class RoundStuff
        {
            //method to do the rounding
            public void  Rounded(double num1, int num2)
            {
                //the actual math
                double complete = Math.Round(num1, num2);
                //printing the value
                Console.WriteLine("Hi! Below is the rounded number");
                Console.WriteLine(complete);
            }
        }

        static void Main(string[] args)
        {
            //making a class object for the method
            RoundStuff classObj = new RoundStuff();
            //making a random object
            Random rng = new Random();
            //making random double and int for variety in rounding
            double num1= rng.Next(0,3);
            int num2 = rng.Next(1,6);

            //making the delegate equal to the class object
            ImRounding delRound = new ImRounding(classObj.Rounded);
            //actually using the delegate and assigning its values
            delRound(num1, num2);
            
        }
        
        
        
    }
}

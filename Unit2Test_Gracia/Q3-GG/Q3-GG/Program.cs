using System;
using System.Collections.Generic;
using System.Globalization;

namespace Q3_GG
{

    //Author: Geoff Gracia
    //Purpose: do the instructed formula creation from Q3. Used available workspace to demo Q11
    //Restrcitions: Need to obey guidelines of Q3
    internal class Program
    {





        ///
        // Question 11
        ///
        public class MyClass
        {
            public int myInt;

            public MyClass(int nVal)
            {
                this.myInt += nVal;
            }

        }

            public class MyDerivedClass : MyClass
            {
                public MyDerivedClass(int nVal) : base(nVal)
                {
                    this.myInt =(this.myInt + 2) *4;
                }

            }


        static void Main(string[] args)
        {
            //for Q11
            MyDerivedClass myObj = new MyDerivedClass(42);
            Console.WriteLine(myObj.myInt);

            ///
            //for Q3
            ///

            SortedList<(double, double, double), double> sortedList = new SortedList<(double, double, double), double>();

            // Define the range and increment values for w, x, and y
            double wStart = -2.0;
            double wEnd = 0.0;
            double wIncrement = 0.2;

            double yStart = -1.0;
            double yEnd = 1.0;
            double yIncrement = 0.1;

            double xStart = 0.0;
            double xEnd = 4.0;
            double xIncrement = 0.1;

            // Iterate over the specified ranges and calculate z
            for (double w = wStart; w <= wEnd; w += wIncrement)
            {
                for (double y = yStart; y <= yEnd; y += yIncrement)
                {
                    for (double x = xStart; x <= xEnd; x += xIncrement)
                    {
                        // Calculate z using the formula
                        double z = Math.Round(4 * Math.Pow(y, 3) + 2 * Math.Pow(x, 2) - 8 * w + 7, 3);

                        // Create a tuple as the key and add z to the SortedList
                        var key = (Math.Round(w, 1), Math.Round(x, 1), Math.Round(y, 1));
                        sortedList[key] = z;
                    }
                }
            }

            // Print the SortedList
            foreach (var item in sortedList)
            {
                Console.WriteLine("{0}, {1}, {2}, = {3}", item.Key.Item1, item.Key.Item2, item.Key.Item3, item.Value);
            }
        }
    }
}

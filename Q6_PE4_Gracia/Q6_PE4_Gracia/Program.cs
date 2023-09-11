using System;

namespace Q6_PE4_Gracia
{
    // Author: Geoff Gracia
    // Purpose:PE 4 image coordinates code for question 6 
    // Restrictions: None

    internal class Program
    {
        // Method: Main
        // Purpose: Loop to display image based on user input x and y coordinates
        // Output: image that is displayed based on user input
        // Restrictions: None

        static void Main(string[] args)
        {
            ///
            //Question 6
            ///

            //prompt directions
            Console.WriteLine("Please give new start and end values for realCoord and ImgCoord");

            //prompts for each set 
            //for start and end coords of realCoord
            Console.Write("Enter start value for realCoord (between 49 and 100): ");
            string readRC1 = Console.ReadLine();
            double varRC1 = double.Parse(readRC1);
            Console.WriteLine();
            Console.Write("Enter end value for realCoord (between 1 and 15): ");
            string readRC2 = Console.ReadLine();
            double varRC2 = double.Parse(readRC2);
            Console.WriteLine();
            //for start and end values of ImgCoord
            Console.Write("Now enter the start value for ImgCoord  (between 10 and 25): ");
            string readIC1 = Console.ReadLine();
            double varIC1 = double.Parse(readIC1);
            Console.Write("Enter end value for ImgCoord (between 80 and 120): ");
            string readIC2 = Console.ReadLine();
            double varIC2 = double.Parse(readIC2);
            Console.WriteLine();

            //conditional statement for any of the entered inputs being incorrect and then just restating the prompt 
            if ( (varRC1 >100 || varRC1 <49) || (varRC2 > 15 || varRC2 < 1) || (varIC1 > 25 || varIC1 < 10 ) || (varIC2 > 120 || varIC2 < 80 )  )
            {

                Console.WriteLine("Invalid choices. Again, please make sure ONLY ONE variable is greater than 10 (the OTHER SHOULD BE LESS than 10)");
                Console.WriteLine();
                Console.Write("Enter start value for realCoord (between 49 and 100): ");
                readRC1 = Console.ReadLine();
                varRC1 = double.Parse(readRC1);
                Console.WriteLine();
                Console.Write("Enter end value for realCoord (between 1 and 15): ");
                readRC2 = Console.ReadLine();
                varRC2 = double.Parse(readRC2);
                Console.WriteLine();
                Console.Write("Now enter the start value for ImgCoord  (between 10 and 25): ");
                 readIC1 = Console.ReadLine();
                 varIC1 = double.Parse(readIC1);
                Console.Write("Enter end value for ImgCoord (between 80 and 120): ");
                 readIC2 = Console.ReadLine();
                 varIC2 = double.Parse(readIC2);
                Console.WriteLine();
            }
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
            {
                for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                           - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }
                }
                Console.Write("\n");
            }
        }
    }
}

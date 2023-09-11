using System;

namespace Q6_PE4_Gracia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///
            //Question 6
            ///

            Console.WriteLine("Please give new start and end values for realCoord and ImgCoord");

            Console.Write("Enter start value for realCoord (between 49 and 100): ");
            string readRC1 = Console.ReadLine();
            int varRC1 = int.Parse(readRC1);
            Console.WriteLine();
            Console.Write("Enter end value for realCoord (between 1 and 15): ");
            string readRC2 = Console.ReadLine();
            int varRC2 = int.Parse(readRC2);
            Console.WriteLine();
            Console.Write("Now enter the start value for ImgCoord  (between 10 and 25): ");
            string readIC1 = Console.ReadLine();
            int varIC1 = int.Parse(readIC1);
            Console.Write("Enter end value for ImgCoord (between 80 and 120): ");
            string readIC2 = Console.ReadLine();
            int varIC2 = int.Parse(readIC2);


            if ( (varRC1 >100 || varRC1 <49) || (varRC2 > 15 || varRC2 < 1) || (varIC1 > 25 || varIC1 < 10 ) || (varIC2 > 120 || varIC2 < 80 )  )
            {
                Console.WriteLine("Invalid choices. Again, please make sure ONLY ONE variable is greater than 10 (the OTHER SHOULD BE LESS than 10)");
                Console.WriteLine();
                Console.Write("Enter start value for realCoord (between 49 and 100): ");
                readRC1 = Console.ReadLine();
                varRC1 = int.Parse(readRC1);
                Console.WriteLine();
                Console.Write("Enter end value for realCoord (between 1 and 15): ");
                readRC2 = Console.ReadLine();
                varRC2 = int.Parse(readRC2);
                Console.WriteLine();
                Console.Write("Now enter the start value for ImgCoord  (between 10 and 25): ");
                 readIC1 = Console.ReadLine();
                 varIC1 = int.Parse(readIC1);
                Console.Write("Enter end value for ImgCoord (between 80 and 120): ");
                 readIC2 = Console.ReadLine();
                 varIC2 = int.Parse(readIC2);
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

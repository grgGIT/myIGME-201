using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE8_Gracia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

        ///
        //Q5 
        ///

        //z = 3y2 + 2x - 1
        //	-1 <= x <= 1 in 0.1 increments
        //	1 <= y <= 4 in 0.1 increments

        //3d array
        double[,,]  Arr3d = new double [21,31,3];

            //reference variables for the 3 parts of the array
            double x;
            double y;
            double z;

            //reference for the number indexes
            int indx1 = 0;
            int indx2 = 0;

            //	-1 <= x <= 1 in 0.1 increments
            for (x = -1; x <= 1; x += 0.1)
            {
                //make double an int basically
                x = Math.Round(x, 1);

                //	1 <= y <= 4 in 0.1 increments
                for (y = 1; y <=4; y += 0.1)
                {
                    //make double an int basically
                    y = Math.Round(y, 1);


                    //z = 3y2 + 2x - 1
                    z = 3 * (y * y) + 2 * x - 1;

                    //make double an int basically
                    z = Math.Round(z, 1);

                    //saving values to stuff
                    Arr3d[indx1, indx2, 0] = x;

                    Arr3d[indx1, indx2, 1] = y;

                    Arr3d[indx1, indx2, 2] = z;

                    ++indx2;
                }

                ++indx1;
                
            }
            


            ///
            //Q7
            ///

            //prompt
            Console.Write("Write a sentence: ");
            string readin = Console.ReadLine();

            //show original
            Console.WriteLine("This was what you entered: {0}", readin);
            //initalize
            string reversed = "";

            //for the length of the string, reverse through that sentence
            for (int i = readin.Length -1; i >= 0; i--)
            {
                reversed += readin[i];
            }
            //show new
            Console.WriteLine("Reversed sentence: {0}", reversed);


            ///
            //Q8
            ///

            //prompt
            Console.Write("Enter a sentence with 'no' being used in it: ");
            string readin2 = Console.ReadLine();
            //show original
            Console.WriteLine("This was what you entered: {0}", readin2);
            //replace
            readin2 = readin2.Replace("no", "yes");
            //show new
            Console.WriteLine("Newly swapped: {0}", readin2);

            ///
            //Q9
            ///

            //prompt
            Console.Write("Enter a sentence: ");
            string readin3 = Console.ReadLine();

            //array creation 
            string[] wordsArr = readin3.Split(' ');

            //double quotes

            foreach (string word in wordsArr)
            {
                Console.WriteLine(" {0}", word);
            }



        }
    }
}

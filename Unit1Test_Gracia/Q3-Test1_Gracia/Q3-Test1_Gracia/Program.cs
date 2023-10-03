using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Test1_Gracia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int rndm = random.Next(0,4);
            Console.WriteLine(rndm);
        }
    }
}

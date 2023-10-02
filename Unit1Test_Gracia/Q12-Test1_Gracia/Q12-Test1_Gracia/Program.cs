using System;

namespace Q12_Test1_Gracia
{
    internal class Program
    {
        static bool GiveRaise(string name, double salary)
        {
            if (name == "Geoff")
            {
                salary += 19000;
                Console.WriteLine("Congratulations {0} on your new raise! Your new salary is {1}", name, salary);
                return true;
            }
            else
            {
                Console.WriteLine("Ooo sorry no raise for you goodbye! Try again next time!");
                Environment.Exit(0);
                return false;
            }
        }

        static void Main(string[] args)
        {

            string sName;
            double dSalary = 30000;

            Console.WriteLine("As a note for testing, YOUR NAME SHOULD BE 'Geoff' ");
            Console.WriteLine();
            Console.Write("What is thy name (I'm looking for someone named Geoff)? : ");
            sName = Console.ReadLine();
            Console.WriteLine();

            GiveRaise(sName, dSalary);

           
        }
    }
}
  
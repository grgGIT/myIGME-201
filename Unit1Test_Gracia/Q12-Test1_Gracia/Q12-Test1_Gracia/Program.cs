using System;

namespace Q12_Test1_Gracia
{
    internal class Program
    {
        //Q13 edits below

        //struct and its pieces
        struct Employee
        {
            public string sName;
            public double dSalary;

           
        }
      

        static void Main(string[] args)
        {
            Employee myEmply = new Employee();
           
            //testing hint
            Console.WriteLine("As a note for testing, YOUR NAME SHOULD BE 'Geoff' ");
            Console.WriteLine();
            //prompt
            Console.Write("What is thy name (I'm looking for someone named Geoff)? : ");
            //assign to struct property
            myEmply.sName = Console.ReadLine();
            Console.WriteLine();

            //call method
            GiveRaise(myEmply);

           
        }
        //method to do the workinz stuff
        static bool GiveRaise(Employee employee)
        {
            // if name is Geoff then salary raise
            if (employee.sName == "Geoff")
            {
                employee.dSalary += 19000;
                Console.WriteLine("Congratulations {0} on your new raise! Your new salary is {1}", employee.sName, employee.dSalary);
                return true;
            }
            else
            {
                //otherwise exit game
                Console.WriteLine("Ooo sorry no raise for you goodbye! Try again next time!");
                Environment.Exit(0);
                return false;
            }


            /* This is for Q12
             

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
           
             */
        }
    }
}
  
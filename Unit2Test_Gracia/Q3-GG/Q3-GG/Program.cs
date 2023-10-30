using System;
using System.Collections.Generic;
using System.Globalization;

namespace Q3_GG
{
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

        public class Birthday
        {
            SortedList<string, DateTime> friendBirthdays = new SortedList<string, DateTime>();
            //where string = friend's name and DateTime = their birthdate (use the format string "MM/dd/yyyy" in your output)
            string friendDay = "04-21-1962";
            DateTime parsedDate;
            foreach (var date in SortedList)
        {
            if (DateTime.TryParseExact(dateValue, pattern, null,
                                      System.Globalization.DateTimeStyles.None, out parsedDate))
                Console.WriteLine("Converted '{0}' to {1:d}.",
                                  dateValue, parsedDate);
            else
                Console.WriteLine("Unable to convert '{0}' to a date and time.",
                                  dateValue);
        }
    }

        public class MyClass2
        {
            public int myInt2;
            public List<string> myList;

            public My()
            {
                myInt2 = 42;
                myList = new List<string>();
                myList.Add("Item 1");
                myList.Add("Item 2");
            }

            // Method to create a shallow copy
            public MyClassCopy()
            {
                MyClassCopy copy = new MyClass2();
                copy.myInt2 = this.myInt2;
                copy.myList = this.myList; // Share the reference to the same list
                return copy;
            }
        }

        ///
        // Q3
        ///


        static void Main(string[] args)
        {
            //for Q11
            MyDerivedClass myObj = new MyDerivedClass(42);
            Console.WriteLine(myObj.myInt);


            //for Q3
        }
    }
}

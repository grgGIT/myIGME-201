using System;

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

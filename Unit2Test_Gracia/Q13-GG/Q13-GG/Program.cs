using System;
using System.Collections.Generic;

namespace Q13_GG
{
    internal class Program
    {
        public class MyClass
        {
            public int myInt2;
            public List<string> myList;

            public MyClass()
            {
                myInt2 = 42;
                myList = new List<string>();
                myList.Add("Item 1");
                myList.Add("Item 2");
            }

            // Method to create a shallow copy
            public MyClass MyClassCopy()
            {
                MyClass copy = new MyClass();
                copy.myInt2 = this.myInt2;
                copy.myList = this.myList; // Share the reference to the same list
                return copy;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

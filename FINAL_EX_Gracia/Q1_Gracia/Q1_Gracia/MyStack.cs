using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Gracia
{
    internal class MyStack
    {
        private List<int> stackList;

        public MyStack()
        {
            stackList = new List<int>();
        }

        // Push method to add an element to the top of the stack
        public void Push(int n)
        {
            stackList.Add(n);
        }

        // Pop method to remove and return the element from the top of the stack
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty. Cannot pop.");
            }

            int lastIndex = stackList.Count - 1;
            int poppedItem = stackList[lastIndex];
            stackList.RemoveAt(lastIndex);
            return poppedItem;
        }

        // Peek method to return the element from the top of the stack without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The stack is empty. Cannot peek.");
            }

            return stackList[stackList.Count - 1];
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return stackList.Count == 0;
        }
    }

    class Program
    {
        static void Main()
        {
            // Example usage of MyStack
            MyStack myStack = new MyStack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);

            Console.WriteLine("Peek: " + myStack.Peek()); // Output: 30

            Console.WriteLine("Pop: " + myStack.Pop());   // Output: 30
            Console.WriteLine("Peek: " + myStack.Peek()); // Output: 20

            myStack.Push(40);

            Console.WriteLine("Pop: " + myStack.Pop());   // Output: 40
            Console.WriteLine("Pop: " + myStack.Pop());   // Output: 20
            Console.WriteLine("Pop: " + myStack.Pop());   // Output: 10

            // Uncommenting the line below would throw an InvalidOperationException since the stack is empty.
            // Console.WriteLine("Pop: " + myStack.Pop());
        }
    }
}

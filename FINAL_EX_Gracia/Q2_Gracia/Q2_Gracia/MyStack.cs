using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Gracia
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
}

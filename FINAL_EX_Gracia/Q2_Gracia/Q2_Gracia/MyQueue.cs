using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_Gracia
{
    internal class MyQueue
    {
        private List<int> queueList;

        public MyQueue()
        {
            queueList = new List<int>();
        }

        // Enqueue method to add an element to the end of the queue
        public void Enqueue(int n)
        {
            queueList.Add(n);
        }

        // Dequeue method to remove and return the element from the front of the queue
        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty. Cannot dequeue.");
            }

            int frontItem = queueList[0];
            queueList.RemoveAt(0);
            return frontItem;
        }

        // Peek method to return the element from the front of the queue without removing it
        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("The queue is empty. Cannot peek.");
            }

            return queueList[0];
        }

        // Check if the queue is empty
        public bool IsEmpty()
        {
            return queueList.Count == 0;
        }
    }
}

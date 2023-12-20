using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Gracia
{
    internal class MinHeap
    {
        private HeapNode[] heap;
        private int capacity;
        private int size;

        // Constructor to initialize the min-heap with a given capacity
        public MinHeap(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            this.heap = new HeapNode[capacity];
        }

        // Checks if the heap is empty
        public bool IsEmpty()
        {
            return size == 0;
        }

        // Inserts a new node into the heap
        public void Insert(HeapNode node)
        {
            heap[size] = node;
            HeapifyUp(size);
            size++;
        }

        // Extracts the node with the minimum distance from the heap
        public HeapNode ExtractMin()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Heap is empty");
            }

            HeapNode minNode = heap[0];
            heap[0] = heap[size - 1];
            size--;

            HeapifyDown(0);

            return minNode;
        }

        // Maintains the heap property by moving a node up the heap
        private void HeapifyUp(int index)
        {
            int parent = (index - 1) / 2;

            while (index > 0 && heap[index].Distance < heap[parent].Distance)
            {
                Swap(index, parent);
                index = parent;
                parent = (index - 1) / 2;
            }
        }

        // Maintains the heap property by moving a node down the heap
        private void HeapifyDown(int index)
        {
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;
            int smallest = index;

            if (leftChild < size && heap[leftChild].Distance < heap[smallest].Distance)
            {
                smallest = leftChild;
            }

            if (rightChild < size && heap[rightChild].Distance < heap[smallest].Distance)
            {
                smallest = rightChild;
            }

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        // Swaps two nodes in the heap
        private void Swap(int i, int j)
        {
            HeapNode temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}

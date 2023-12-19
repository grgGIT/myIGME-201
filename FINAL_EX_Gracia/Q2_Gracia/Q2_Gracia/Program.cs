// See https://aka.ms/new-console-template for more information
using Q2_Gracia;


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




MyQueue myQueue = new MyQueue();

myQueue.Enqueue(10);
myQueue.Enqueue(20);
myQueue.Enqueue(30);

Console.WriteLine("Peek: " + myQueue.Peek()); // Output: 10

Console.WriteLine("Dequeue: " + myQueue.Dequeue());   // Output: 10
Console.WriteLine("Peek: " + myQueue.Peek());         // Output: 20

myQueue.Enqueue(40);

Console.WriteLine("Dequeue: " + myQueue.Dequeue());   // Output: 20
Console.WriteLine("Dequeue: " + myQueue.Dequeue());   // Output: 30
Console.WriteLine("Dequeue: " + myQueue.Dequeue());   // Output: 40

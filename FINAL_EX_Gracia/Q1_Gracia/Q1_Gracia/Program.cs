// See https://aka.ms/new-console-template for more information
using Q1_Gracia;

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



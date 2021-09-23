using System;

namespace Stack_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and Queues");
            Stack<int> Stack = new Stack<int>();
            Stack.Push(70);
            Stack.Push(30);
            Stack.Push(56);
            Stack.Display();
            Stack.Peek();
            Stack.Pop();
            Stack.Empty();
        }
    }
}

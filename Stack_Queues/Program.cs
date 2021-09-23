using System;

namespace Stack_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and Queues");
            Stack Stack = new Stack();
            Stack.Push(70);
            Stack.Push(30);
            Stack.Push(56);
            Stack.Display();
        }
    }
}

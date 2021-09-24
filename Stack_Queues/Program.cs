using System;

namespace Stack_Queues
{
  class Program
    {
     static void Main(string[] args)
     {
        Console.WriteLine("Welcome to stack and Queues");        
        int count = 0;//counter to break the while loop
        while (count == 0)
        {
           Console.WriteLine("1:Stack  2:Queue  3:Exit");
           int choice = Convert.ToInt32(Console.ReadLine());//variable for taking choice from the user
           Console.WriteLine("\n");
           switch (choice)  //switch case
           {
               case 1:
                   Stack<int> Stack = new Stack<int>();
                   Stack.Push(70);
                   Stack.Push(30);
                   Stack.Push(56);
                   Stack.Display();
                   Stack.Peek();
                   Stack.Pop();
                   Stack.Empty();
                   break;
                case 2:
                   Queue<int> Queue = new Queue<int>();
                   Queue.Enqueue(70);
                   Queue.Enqueue(30);
                   Queue.Enqueue(56);
                   Console.WriteLine("before dequeue : ");
                   Queue.Display();
                   Queue.Dequeue();
                   Console.WriteLine("\nafter dequeue : ");
                   Queue.Display();
                   break;
                 default:
                   Console.WriteLine("Exit");//default condition
                   count++;
                   break;
           }
        }
     }
  }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queues
{
    class Queue<Gtype>
    {
        Node<Gtype> head = null;
        internal void Enqueue(Gtype data)
        {
            Node<Gtype> node = new Node<Gtype>(data);
            if (head == null)
                head = node;
            else
            {
                Node<Gtype> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} added", node.data);
        }

        internal void Display()
        {
            Node<Gtype> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

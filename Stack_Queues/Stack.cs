using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queues
{
    class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int no)
        {
            Node node = new Node(no);
            if (this.top == null)
                node.next = null;
            else
                node.next = top;
            this.top = node;
            Console.WriteLine("{0} pushed", no);
        }
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

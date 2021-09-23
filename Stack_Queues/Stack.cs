using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Queues
{
    class Stack<Gtype>
    {
        private Node<Gtype> top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(Gtype no)
        {
            Node<Gtype> node = new Node<Gtype>(no);
            if (this.top == null)
                node.next = null;
            else
                node.next = top;
            this.top = node;
            Console.WriteLine("{0} pushed", no);
        }
        public void Display()
        {
            Node<Gtype> temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("\n{0} is at top of the stack ", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is popped", this.top.data);
            this.top = this.top.next;
        }
        internal void Empty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}

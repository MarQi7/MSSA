using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
    class NodeStack
    {
        Node top;
        int size;
        public NodeStack() 
        {
            top = null;
            size = 0;
        }

        public bool IsEmpty() { return size == 0; }

        public void Push(int val)
        {
            Node newest = new Node(val,null);
            if(IsEmpty())
            {
                top = newest;
            }
            else
            {
                newest.next = top;
                top = newest;
            }
            size++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty... cannot pop");
                return -1;
            }
            else
            {
                int val = top.data;
                top = top.next;
                size--;
                return val;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty... cannot pop");
                return -1;
            }
            else
            {
                return top.data;
            }
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty...");
            }
            Node t = top;
            while(t != null)
            {
                Console.WriteLine(t.data);
                t = t.next;
            }


        }
    }
}

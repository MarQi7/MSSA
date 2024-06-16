using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int data,Node next=null) 
        {
            this.data = data;
            this.next = next;
        }
    }
    class LinkedQueue
    {
        Node front;
        Node rear;
        int size;
        public int Length { get { return size; } }

        public LinkedQueue()
        {
            front = null;
            rear = null;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(int val)
        {
            Node newest = new Node(val, null);
            if (IsEmpty())
            {
                front = newest;
            }
            else
            {
                rear.next = newest;
            }
            rear = newest;
            size++;
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                int val = front.data;
                front = front.next;
                size--;
                Console.WriteLine($"Next up: {val}");
            }
            if (IsEmpty())
            {
                rear = null;
            }
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty...");
                return;
            }
            Node q = front;
            while(q != null)
            {
                
                Console.WriteLine($"{q.data}");
                q = q.next;

            }
        }


    }
}

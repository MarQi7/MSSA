using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    internal class Queue
    {
        class Node
        {
            public Customer data;
            public Node next;
            public Node(Customer data, Node next = null)
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

            public void Enqueue(Customer val)
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
                    Customer val = front.data;
                    front = front.next;
                    size--;
                    Console.WriteLine($"Next up: {val.Name} Phone: {val.Phone}\n\n{val.Question}\n\n");
                    for(int i = 0; i < val.Options.Length; i++)
                    {
                        Console.WriteLine($"[{i+1}] {val.Options[i]}");
                    }
                    //return the queued customers answer value? [ used for the outter answering section to compare ]
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
                    Console.WriteLine("There are no customers in queue...");
                    return;
                }
                Node q = front;
                while (q != null)
                {

                    Console.WriteLine($"{q.data.Name}");
                    q = q.next;

                }
            }


        }
    }
}

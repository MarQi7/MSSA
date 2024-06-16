using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    internal class ArrayQueue
    {
        int[] data;
        int front, rear, size;
        public ArrayQueue(int n)
        {
            data=new int[n];
            front = 0;
            rear = 0;
            size = 0;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public bool IsFull()
        {
            return rear == data.Length - 1;
        }

        public void Enqueue(int val)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full...");
                return;
            }
            else 
            {
                if(rear < data.Length - 1)
                {
                    rear++;
                }
                data[rear] = val;
                size++;
            }
        }

        public string Dequeue()
        {
            if(IsEmpty())
            {
                return "The queue is empty...";
            }
            else
            {
                front++;
                size--;
                return $"next up: {front}";
            }
        }

        public void Display()
        {
            if (!IsEmpty())
            {
                int q = front + 1;
                while (q <= rear)
                {
                    Console.WriteLine($"{q}: {data[q]}");
                    q++;
                }
            }
            else Console.WriteLine("The queue is empty...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Stacker
    {
        
        int[] data; //use var or generic <T>?
        int top;
        public Stacker(int size)
        {
            this.data = new int[size]; //allocating size ...
            top = -1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
        
        public bool IsFull()
        {
            return top == data.Length-1;
        }

        public void Push(int value)
        {
            if(IsFull())
            {
                Console.WriteLine("Stack is full, cannot push");
            }
            else
            {
                top ++;
                data[top] = value;
            }
        }

        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot pop");
                return -1;
            }
            else
            {
                int value = data[top];
                top --;
                return value;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty, cannot peek");
                return -1;
            }
            return data[top];
            
        }

        public void Display()
        {
            while (top >= 0)
            {
                Console.WriteLine($"{data[top]}");
                top--;
            }
        }
    }
}

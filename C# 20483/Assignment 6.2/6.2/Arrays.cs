using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Arrays
    {
        class Node
        {
            public int[] data;
            public Node next;
            public Node(int[] data, Node next)
            {
                this.data = data;
                this.next = next;
            }
        }
        class ArrayNodeStack
        {
            Node top;
            int size;
            public ArrayNodeStack()
            {
                top = null;
                size = 0;
            }

            public bool IsEmpty() { return size == 0; }

            public void Push(int[] val)
            {
                Node newest = new Node(val, null);
                if (IsEmpty())
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

            public string Pop()
            {
                if (IsEmpty())
                {
                    return "The stack is empty... cannot pop";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append("Array [");

                    foreach (int i in top.data)
                    {
                        sb.Append($"{i},");
                    }

                    sb.Remove(sb.Length - 1, 1);
                    sb.Append("] was popped!");

                    top = top.next;
                    size--;

                    return sb.ToString();
                }
            }

            public string Peek()
            {
                if (IsEmpty())
                {
                    return "The stack is empty... cannot pop";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append("The next array is: [");

                    foreach (int i in top.data)
                    {
                        sb.Append($"{i},");
                    }

                    sb.Remove(sb.Length - 1, 1);
                    sb.Append("]");

                    return sb.ToString();
                }
            }

            public void Display()
            {
                if (IsEmpty())
                {
                    Console.WriteLine("The stack is empty...");
                }
                Node t = top;
                while (t != null)
                {
                    StringBuilder sb = new StringBuilder();

                    sb.Append("[");

                    foreach (int i in t.data)
                    {
                        sb.Append($"{i},");
                    }

                    sb.Remove(sb.Length - 1, 1);
                    sb.Append("]");

                    Console.WriteLine(sb.ToString());

                    t = t.next;
                }


            }
        }
    }
}

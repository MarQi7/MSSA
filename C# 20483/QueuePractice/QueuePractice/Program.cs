using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> strings = new Queue<string>();
            ArrayQueue queue = new ArrayQueue(15);
            LinkedQueue myNodes = new LinkedQueue();
            strings.Enqueue("Alex");
            strings.Enqueue("Andre");
            strings.Enqueue("Andrew");
            strings.Enqueue("Arnold");
            strings.Enqueue("Axel");
            Console.WriteLine("\nBefore dequeue:");
            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }
            strings.Dequeue();
            Console.WriteLine("\nAfter dequeue:");
            foreach (var item in strings)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("");
            Console.WriteLine("");
            myNodes.Enqueue(7);
            myNodes.Enqueue(22);
            myNodes.Enqueue(27);
            myNodes.Enqueue(2);
            myNodes.Enqueue(1);
            myNodes.Enqueue(21);
            myNodes.Enqueue(11);
            myNodes.Enqueue(41);
            myNodes.Enqueue(25);
            Console.WriteLine("\nBefore dequeue:");
            myNodes.Display();

            Console.WriteLine("Len:" + myNodes.Length);
            myNodes.Dequeue();
            myNodes.Dequeue();
            Console.WriteLine("\nAfter dequeue:");
            myNodes.Display();
            Console.WriteLine("\nFull dequeue:");

            while (myNodes.Length> 0)
            {
                myNodes.Dequeue();
            }
            Console.WriteLine("");
            Console.WriteLine("Len:" + myNodes.Length);
            Console.ReadKey();
        }
    }
}

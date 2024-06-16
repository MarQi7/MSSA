using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stacker intstack = new Stacker(10);
            NodeStack intstack = new NodeStack();
            //Stack<int> intstack = new Stack<int>();
            intstack.Push(1);
            intstack.Push(2);
            intstack.Push(3);
            intstack.Pop();
            intstack.Push(4);
            intstack.Pop();
            intstack.Push(1);
            intstack.Push(2);
            intstack.Push(3);
            intstack.Push(7);
            intstack.Push(7);
            intstack.Push(7);

            intstack.Display();
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTech
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int test = 23;
        static void Main(string[] args)
        {
            Console.WriteLine(RecurFuncs.RecursiveSquares(test,sb));
            Console.WriteLine();
            Console.WriteLine(RecurFuncs.FactR(4));
            Console.WriteLine(RecurFuncs.FactorialR(4));
            Console.WriteLine(RecurFuncs.Factorial(4));
            Console.ReadKey();
        }
    }
}

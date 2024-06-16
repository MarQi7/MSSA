using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    internal class Program
    {
        static int[] ints1 = {1,0,0,0,1,0,1,0,0,1};
        static int[] ints2 = {1,0,0,0,1,0,0,0,0,1}; // I don't know why the number changes in this function...
        static int[] ints3 = { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0 ,0 ,0 , 0};
        static int result = 0;
        static void Main(string[] args)
        {

            Console.WriteLine(Plants.AdjacentCheckSplit(ints1, 1)); //true
            Console.WriteLine(Plants.AdjacentCheckSplit(ints1, 2)); //false
            Console.WriteLine(Plants.AdjacentCheckSplit(ints2, 1)); //true
            Console.WriteLine(Plants.AdjacentCheckSplit(ints2, 2)); //true
            Console.WriteLine(Plants.AdjacentCheckSplit(ints3, 3)); //true
            Console.WriteLine(Plants.AdjacentCheckSplit(ints3, 4)); //true


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(Plants.AdjacentCheckLoop(ints1, 1)); 
            Console.WriteLine(Plants.AdjacentCheckLoop(ints1, 2));
            Console.WriteLine(Plants.AdjacentCheckLoop(ints2, 1));
            Console.WriteLine(Plants.AdjacentCheckLoop(ints2, 2));
            Console.WriteLine(Plants.AdjacentCheckLoop(ints3, 3));
            Console.WriteLine(Plants.AdjacentCheckLoop(ints3, 4));

            Climp.TwoStepRecurse(7, ref result);
            Console.WriteLine($"# of stairs: 7\nResult: {result}");
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

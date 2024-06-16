using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Challenge_Lab
{
    
    internal class Program
    {
        static Dictionary<int, int> numcount = new Dictionary<int, int>();
        static int even=0;
        static int odd=0;
        static int[] test1 = { 3, 0, 1 };
        static int[] test2 = { 0, 1 ,2};
        static int[] test3 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
        static int[] test4 = { 9, 1, 1, 9, 4, 5, 3, 1, 5, 1, 3, 9, 3 };
        static void Main(string[] args)
        {

            Console.WriteLine("Week 5 Challenge Labs\n\nPart 1:");
            
            Console.WriteLine($"Input: [9, 9, 4, 5, 3, 5, 3, 9, 3] Least occuring #: {ArrayFuncs.FoundOne(test4, numcount)}"); // should be 4
            Console.WriteLine("\nPart 2:"); 
            Console.WriteLine($"Input: [3, 0, 1]   MissingNo:{ArrayFuncs.MissingNo(test1)}");
            Console.WriteLine(); 
            Console.WriteLine($"Input: [0, 1 ,2]   MissingNo:{ArrayFuncs.MissingNo(test2)}");
            Console.WriteLine();
            Console.WriteLine($"Input: [9, 6, 4, 2, 3, 5, 7, 0, 1]   MissingNo:{ArrayFuncs.MissingNo(test3)}"); // should return 4
            Console.WriteLine(Checker.Robber_planning(test4));
            Console.WriteLine(Checker.MaxEvenOdd(test4));
            Console.WriteLine(Checker.MaxEvenOddRecursive(test4,ref even,ref odd));
            //Console.WriteLine(ArrayFuncs.Found(test3));
            //Console.WriteLine(ArrayFuncs.Found(test3));

            Console.ReadKey();
        }
    }
}

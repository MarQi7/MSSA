using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Program
    {
        static int[] nums = { -1, 1, 0, -3, 3 };
        static int[] nums2 = { 2, 1, 7, 9, 13 };
        static int[] nums3 = { 1, 2, 3, 4 };
        static ArrayNodeStack stacked = new ArrayNodeStack();
        static void Main(string[] args)
        {

            Console.WriteLine("Assignment 6.2");
            Console.WriteLine("\nImplimenting a stack using an array:");
            Console.WriteLine("\t------------");
            stacked.Push(nums);
            stacked.Push(nums2);
            stacked.Push(nums3);
            Console.WriteLine();
            Console.WriteLine(stacked.Peek());
            Console.WriteLine();
            Console.WriteLine(stacked.Pop());
            Console.WriteLine();
            stacked.Display();
            Console.WriteLine();
            Console.WriteLine("Returning an array[i] exclusive product value");
            Console.WriteLine("\t\t------------");
            Console.WriteLine($"\nWith the array [-1, 1, 0, -3, 3]");
            Console.WriteLine(ProductExeption.ProductExclusiveNums(nums));
            Console.WriteLine($"\nWith the array [2, 1, 7, 9, 13]");
            Console.WriteLine(ProductExeption.ProductExclusiveNums(nums2));
            Console.WriteLine($"\nWith the array [1, 2, 3, 4]");
            Console.WriteLine(ProductExeption.ProductExclusiveNums(nums3));
            Console.WriteLine();
            Console.ReadKey();


        }

        
    }
}

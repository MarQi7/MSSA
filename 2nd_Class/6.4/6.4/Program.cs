using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    internal class Program
    {
        static int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        static int[,] matrix2 = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };
        static int[] test = { 5, 1, 9, 11 };
        static void Main(string[] args)
        {

            Display(test);
            Console.WriteLine();
            Console.WriteLine("Cheap methods w/string:");
            MatrixRotation.RotateClockwiseCheat(matrix);
            Console.WriteLine();
            MatrixRotation.RotateClockwiseCheat(matrix2);
            Console.WriteLine();
            Console.WriteLine("Using the Z-swap method I came up with.\n\n");
            Console.WriteLine();
            MatrixRotation.RotateClockwise(matrix);
            Console.WriteLine();
            MatrixRotation.RotateClockwise(matrix2);
            Console.ReadKey();

        }
        static void Display<T>(IEnumerable<T> xs) => Console.WriteLine(string.Join(" ", xs));
    }
}

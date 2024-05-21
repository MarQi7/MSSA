using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Program
    {
        static int[] ints = {0,2,1,1,9,1,1};
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 3.1: \n");

            Console.WriteLine("Even #'s in StringBuilder");
            EvenNums.EvenNumsSB();

            Console.WriteLine("\nLeap year checker");
            LeapYear.LYChecker();

            Console.WriteLine("\nSpace counter (Regex?)");
            SpaceCounter.Spacer();  

            Console.WriteLine("\nCoordinate quadrant calculator (TicTacToe?)");
            Coordinator.Quadrant();

            Console.WriteLine("\nFirst consecutive 1's conversion");
            Consecutives.Ones(ints);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}

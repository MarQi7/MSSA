using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace MathEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] one = { 100, 23, 404, 849, 1232, 23, 30, 0 };

            decimal[] three = { -14.50m, 4.23m, -.05m * 404m, -84.9m, -12.32m, .15m * 23m, 2m * 3.0m, 0.1m * 9m };
            int[] cust = new int[10];
            string disp = "[ ";
            string disp2 = "";
            Console.WriteLine("Group Project 1: Finding the largest number and it's index from a given array.\n\n");
            
            //Console.WriteLine("Please input 10 integers. \n\n\n\t\t[ 100, 23, 404, 849, 1232, 23, 30, 0 ]\n\n");
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < cust.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                cust[i] = Convert.ToInt32(Console.ReadLine());
            }
        
            disp2 = String.Join(", ",cust);
            Console.WriteLine("\n\n\n\t\t[" + disp2 +"]\n\n");

            //return index with output of max# used with arr[max].index ??
            //returning an array and displaying results with arr[0] & arr[1]
            //using distinct / to return without considering duplicates (saves iterations)
            //returning duplicates... w/index - second statement, return multiple index's
            //returning a tuple
            //
            Math.FindMax(cust);
            Console.ReadKey();

            /*
            Console.WriteLine("\n\nThe last array includes expresions, decimals, and negatives:\n\n\n\t\t[ -14.50, 4.23, -.05*404, -84.9, -12.32, .15*23, 2*3.0, 0.1*9 ]\n\n");
            Math.FindMax(three);
            */
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

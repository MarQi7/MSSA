using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3._1
{
    internal class Consecutives
    {
        public static void Ones(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            string txtarr = "";
            sb.Append('[');
            foreach(int i in arr) 
            { 
                sb.Append(i+",");
            }
            sb.Remove(sb.Length-2,2);
            sb.Append("]");

            string result = Regex.Replace(sb.ToString(),@"[1](,[1])", "0,0");

            Console.WriteLine($"The input array before the change is {sb}\n");
            Console.WriteLine($"The input array after the change is {result}\n");
            Console.WriteLine();
        }
    }
}

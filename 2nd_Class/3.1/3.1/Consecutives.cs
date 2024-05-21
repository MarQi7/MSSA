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
            sb.Remove(sb.Length-1,1);
            sb.Append("]");
            Regex regex = new Regex(@"[1][,][1]");
            string result = regex.Replace(sb.ToString(), "0,0", 1);
            
            Console.WriteLine($"Version 1:\nThe input array before the change is {sb}\n");
            Console.WriteLine($"The input array after the change is {result}\n");
            Console.WriteLine();

            //Alt solution

            StringBuilder sb2 = new StringBuilder();
            int[] arr2 = arr;
            sb2.Append("[");    
            bool found = false;
            for ( int i = 0; i < arr2.Length; i++ )
            {
                if (i != arr2.Length - 1) 
                { 
                    if (arr2[i] == 1 && arr2[i+1] == 1 && !found)
                    {
                        arr2[i] = 0;
                        arr2[i+1] = 0;
                    
                        found = true;
                    }
                }
                sb2.Append(arr2[i]+", ");
            }
            sb2.Remove(sb2.Length - 2, 2);
            sb2.Append(']');
            Console.WriteLine($"Version 2:\nThe input array after the change is {sb2.ToString()}\n");
            
        }
    }
}

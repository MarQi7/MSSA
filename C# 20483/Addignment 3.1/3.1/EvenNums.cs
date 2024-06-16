using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class EvenNums
    {
        public static void EvenNumsSB() 
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("All even #'s up to 100 (inclusive):");
            for (int i = 1; i < 101; i++)
            { if (i % 2 == 0)
                {
                    sb.Append(i+" ");
                } 
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine("");
        }
    }
}

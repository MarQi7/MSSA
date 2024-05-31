using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class AvgSum
    {
        private static int[] input;
        private static int avg;
        private static int sum;
        
        
        public static int Average(params int[] input)
        {
            return Sum(input)/input.Length;
        }
        public static int Sum(params int[] input)
        {
            foreach (int i in input)
            {
                sum += i;
            }
            return sum;
        }
    }
}

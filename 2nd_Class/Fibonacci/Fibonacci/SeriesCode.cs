using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Fibonacci
{
    internal class SeriesCode
    {
        //public static string FibSeries(int n)
        //{
        //    //using iter loop
        //    int[] nums = new int[n];
        //    //preseting the first few parts of the series is better for time complexity - less iters/comparisons/assignments/prints
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (i > 2) nums[i] = nums[i-2]+ nums[i - 1]; else nums[i] = i;
        //        Console.Write($"{nums[i].ToString()} "); //probably worse than the string.Join on the array
        //    }
        //    return String.Join(" ",nums);
            
        //}
        public static string FibSeries(int n)
        {
            //using iter loop
            int[] nums = new int[n];
            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 1;
            //preseting the first few parts of the series is better for time complexity - less iters/comparisons/assignments/prints
            for (int i = 3; i < n; i++)
            {
                nums[i] = nums[i - 2] + nums[i - 1];
                //Console.Write($"{nums[i].ToString()} "); //probably worse than the string.Join on the array
            }
            return String.Join(" ", nums);

        }
        //public static long? FibSeriesRecursive(int n, Nullable<long>[] sequence)
        //{

        //    if (n == 0) return 0;
        //    if (n == 1) return 1;
        //    return sequence[n]=FibSeriesRecursive(n - 1,sequence) + FibSeriesRecursive(n-2, sequence);

        //}

        //public string FibSeriesStrings(int n)
        //{
        //    //using iter loop
        //    for
        //}
        //public string FibSeriesSB(int n, StringBuilder sb)
        //{
        //    //using iter loop
        //    for
        //}
    }
}

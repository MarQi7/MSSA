using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static Nullable<long>[] longs = new Nullable<long>[15];
        static void Main(string[] args)
        {
            Console.WriteLine(SeriesCode.FibSeries(15));
       //     Console.WriteLine(SeriesCode.FibSeriesRecursive(10,longs));
            Console.WriteLine();

            Console.ReadKey();  
        }
    }
}

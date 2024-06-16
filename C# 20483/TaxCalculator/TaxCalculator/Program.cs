using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex.IsMatch(pattern: @"\d", input: "test");
            int total = 0;
            long product = 1;
            int[] nums = { 1, 2, 3 };
            int i=2, j=3, k=4;
            //Named params 
            CalculateTax(contributions: 300, baseSalary: 3000, filingType: 'J', dependants: 2, state: "NYC");
            Results(out total, out product, i, j, k); //int[] values ex. 32, 33, 1, 21, 45 (unlimited #s OR an int[])
            Console.WriteLine($"Product: {product}\nTotal: {total}");
        
        }
        static void CalculateTax(double baseSalary, double contributions, string state, int dependants = 0, char filingType='X')
        {
            //logic

        }
        static void Results(out int total, out long product, params int[] values)
        {
            product = 1;
            total = 0;
            foreach(int i in values)
            {
                product *= i;
                total += i;
            }
        }
    }
}

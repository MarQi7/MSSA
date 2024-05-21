using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    internal class LeapYear
    {
        public static void LYChecker()
        {
            LeapYear:
            Console.Write("\nEnter the year you would like to check: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0) 
            {
                Console.WriteLine($"\n{year} is a leap year.\n");
            }
            else if (year % 100 != 0 && year % 4 == 0)
            {
                Console.WriteLine($"\n{year} is a leap year.\n");
            }
            else 
            {
                Console.WriteLine($"\n{year} is not a leap year.\n");
            }

            Console.Write("Would you like to check another year? [Y]/[N]: ");
            string ans = Console.ReadLine().ToUpper();
            if (ans == "Y") goto LeapYear;
        }
    }
}

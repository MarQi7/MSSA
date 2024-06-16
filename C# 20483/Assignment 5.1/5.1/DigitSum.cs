using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class DigitSum
    {
        public static void IndividualIntCheck(int num)
        {
            int start = num;
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine($"The sum of digits in the number {start} is {sum}.");
        }

        public static int RecursiveInt(int num, int sum=0)
        {
            sum += num % 10;
            return num / 10 != 0 ? RecursiveInt(num / 10, sum) : sum;
            
            
        }
    }
}

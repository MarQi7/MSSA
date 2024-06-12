using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionTech
{
    public class RecurFuncs
    {
        public static string RecursiveSquares(int n, StringBuilder sb)
        {

            if (n - 1 != 0)
                RecursiveSquares(n - 1, sb);
            sb.Append(n * n + " ");
            return sb.ToString();
        }

        public static long FactorialR(int n)
        {

            if (n > 1)
            {
               return FactorialR(n - 1)*n;
            }else return 1;
        }
        public static long Factorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static long FactR(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
            return FactR(n - 1) * n;
        }

        public static int RecursivePalindromeSB(int num, StringBuilder sb)
        {

            if (num / 10 != 0)
            {
                sb.Append(num % 10);
                return RecursivePalindromeSB(num / 10, sb);
            }
            else return int.Parse(sb.Append(num).ToString());
            // return (num/10 !=0) ? RecursivePalindrom(num/10,sb):num.ToString() == sb.ToString()
        }
        public static int RecursivePalindrome(int num, int num2 = 0)
        {

            num2 = (num2 * 10) + (num % 10);
            //Console.WriteLine(num2);
            if (num / 10 != 0)
                return RecursivePalindrome(num / 10, num2);
            else return num2;
            // returns num to check outside func.
        }
    }
}

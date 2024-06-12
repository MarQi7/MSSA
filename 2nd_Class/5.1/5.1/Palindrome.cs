using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _5._1
{
    internal class Palindrome
    {
        public static bool IntPalindromeCheck(int num)
        {

            string nums = num.ToString();
            char[] chars = nums.ToCharArray();
            Array.Reverse(chars);
            
            nums = String.Concat(chars);
            
            return nums == num.ToString();
            //should try my half comparison
        }
        public StringBuilder sb = new StringBuilder();
        public static int RecursivePalindromeSB(int num, StringBuilder sb)
        {

            if (num / 10 != 0)
            {
                sb.Append(num % 10);
                return RecursivePalindromeSB(num / 10, sb);
            }else return int.Parse(sb.Append(num).ToString());
            // return (num/10 !=0) ? RecursivePalindrom(num/10,sb):num.ToString() == sb.ToString()
        }
        public static int RecursivePalindrome(int num,int num2=0)
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

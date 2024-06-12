using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class RecursTech
    {
        public static string LeadingRecursion(int n)
        {
            return n > 1 ? $"{LeadingRecursion(n - 1)} {n}" : $"{n}";
            /*
            if (n > 1) return $"{LeadingRecursion(n - 1)} {n}";
            else return $"{n}";
            */
        }

        public static string TrailingRecursion(int n)
        {
            return n > 1 ? $"{n} {TrailingRecursion(n - 1)}" : $"{n}";
            /*
            if (n > 1) return $"{n} {TrailingRecursion(n - 1)}";
            else return $"{n}";
            */
        }

        public static string LeadingRecursionSB(int n, StringBuilder sb)
        {
            
            return n > 1 ? $"{LeadingRecursionSB(n - 1,sb)} {n}" : $"{n}";
            /*
            if (n > 1) return $"{LeadingRecursion(n - 1)} {n}";
            else return $"{n}";
            */
        }

        public static string TrailingRecursionSB(int n, StringBuilder sb)
        {
            return n > 1 ? $"{n} {TrailingRecursionSB(n - 1,sb)}" : $"{n}";
            /*
            if (n > 1) return $"{n} {TrailingRecursion(n - 1)}";
            else return $"{n}";
            */
        }
        public static string PalindromeRecursion(string s)
        {
            if (s.Length > 1) return $"{PalindromeRecursion(s.Substring(1))}{s[0]}";
            return s;
        }

        // count using index compare to half or all the way///
        public static string PalindromeRecursionX(string s)
        {
            if (PalindromeRecursionSupport(s, s.Length - 1))
                return $"The string: \"{s}\" is a palindrome.";
            else return $"The string: \"{s}\" is not a palindrome.";
        }

        public static string PalindromeRecursion2(string s, StringBuilder sb)
        {
            sb.Append(s[s.Length-1]);
            if (s.Length > 1) PalindromeRecursion2(s.Substring(0,s.Length-1),sb);
            
            return sb.ToString();
        }
        private static bool PalindromeRecursionSupport(string s, int l,int n=0)
        {
            //Console.WriteLine($"s {s} l:{l} n:{n}");
            if (s[l] == s[n] && l > (s.Length-1)/2) return PalindromeRecursionSupport(s, l - 1, n + 1);
            else if (l <= (s.Length-1)/2) return true;
            else return false;
        }

    }
}

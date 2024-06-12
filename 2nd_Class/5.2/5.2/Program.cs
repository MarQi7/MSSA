using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static string s = "Hello to the programming world!";
        static string s2 = "RADAR";
        static string s3 = "MegaMan";
        static string s4 = "rAlaMaLaR";
        static int n = 10;
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            Console.WriteLine("5.2: Recursion exercises\n");

            Console.WriteLine("Exercise 1: Length of the last word\n");
            string word = SubStrings.LastWord(s);
            Console.WriteLine($"Input: {s}\nLast word: {word}\nLength: {word.Length}");

            Console.WriteLine("\nLeading Recursion");
            Console.WriteLine($"{RecursTech.LeadingRecursion(n)}\n");

            Console.WriteLine("\nTrailing Recursion");
            Console.WriteLine($"{RecursTech.TrailingRecursion(n)}\n");

            Console.WriteLine($"Palindrome Recursion");
            if(RecursTech.PalindromeRecursion(s2)==s2) Console.WriteLine($"The string: \"{s2}\" is a palindrome.");
            else Console.WriteLine($"The string: \"{s2}\" is not a palindrome.");
            Console.WriteLine(RecursTech.PalindromeRecursionX(s3));
            if(RecursTech.PalindromeRecursion2(s4.ToLower(), sb) == s4.ToLower()) Console.WriteLine($"The string: \"{s4}\" is a palindrome.");
            else Console.WriteLine($"The string: \"{s4}\" is not a palindrome.");
            Console.WriteLine();

            Console.ReadKey();
            //no loops in #4 - recursive check
        }
    }
}

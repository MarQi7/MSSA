using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs3
{
    internal class Program
    {
        static string target = "ABFCACDB";
        static string[] rem = { "AB", "CD" };
        static int[] nums = { 2, 7, 11, 15 };
        static int tnum = 9;
  

        static void Main(string[] args)
        {
            Console.WriteLine("Challenge Labs Week 3\n\n");
            Console.WriteLine(">Part 1: Palindrome check\n");
            Console.WriteLine($"IsPalindrome(\"eye\") -> {Palindrome.IsPalindrome("eye")}");
            Console.WriteLine($"IsPalindrome(\"home\") -> {Palindrome.IsPalindrome("home")}");

            Console.WriteLine("\n>Part 2: Sum of digits in a string");

            Console.WriteLine("\nMethod 1");
            Console.WriteLine($"String: \"1q2w3e\": {StringDigitSum.returnSum("1q2w3e")}");
            Console.WriteLine($"String: \"L0r3m.1p5um\": {StringDigitSum.returnSum("L0r3m.1p5um")}");
            Console.WriteLine($"String: \"\": {StringDigitSum.returnSum("")}\n");

            Console.WriteLine("Method 2");
            Console.WriteLine($"String: \"1q2w3e\": {StringDigitSum.returnSum2("1q2w3e")}");
            Console.WriteLine($"String: \"L0r3m.1p5um\": {StringDigitSum.returnSum("L0r3m.1p5um")}");
            Console.WriteLine($"String: \"\": {StringDigitSum.returnSum("")}");

            Console.WriteLine("\n>Part 3: Targeted Sum\n");
            Console.WriteLine($"The input: [2,7,11,15] \nThe target: 9 \nThe result: {TargetSum.TwoSum(nums,tnum)}");

            Console.WriteLine($"\n>Part 4: Removing a substring\n\nString: {target}");

            Console.WriteLine("\nMethod 1");
            Console.WriteLine(RemoveSubString.Remove("ABFCACDB"));

            Console.WriteLine("\nMethod 2");
            Console.WriteLine(RemoveSubString.RemoveStr(target));

            Console.WriteLine("\nMethod 3");
            Console.WriteLine(RemoveSubString.RemoveXtra(target,rem));



            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {   
        static int PalNums = 0;
        static int indNums = 0;
        static int[] test1 = { 2, 4, 5, 6, 7, 8, 9 };
        static int[] test2 = { 3, 3, 5, 6, 7, 4, 4, 3 };
        static StringBuilder sb = new StringBuilder();
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 5.1\n");


            Console.WriteLine("Integer palindrome:");
            Console.Write("Enter a number: ");
            while (PalNums == 0)
            {
                try
                {
                    PalNums = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Please enter a number: ");
                }
            }
            Console.WriteLine(Palindrome.RecursivePalindrome(PalNums)==PalNums);
            Console.WriteLine(Palindrome.RecursivePalindromeSB(PalNums,sb)==PalNums);
            Console.WriteLine(Palindrome.IntPalindromeCheck(PalNums));


            Console.WriteLine("\nIndividual digit sum:");
            Console.Write("Enter a number: ");
            while (indNums == 0)
            {
                try
                {
                    indNums = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.Write("Please enter a number: ");
                }
            }
            DigitSum.IndividualIntCheck(indNums);
            Console.WriteLine($"The sum of digits in the number {indNums} is {DigitSum.RecursiveInt(indNums)}.");
            
            Console.WriteLine("\nDuplicate integer check:\n");
            Console.WriteLine($"Test input [ 2, 4, 5, 6, 7, 8, 9 ]: {Distinct.DistinctIntCheck(test1)}");
            
            Console.WriteLine($"Test input [ 3, 3, 5, 6, 7, 4, 4, 3 ]: {Distinct.DistinctIntCheck(test2)}");
            
            Console.ReadLine();

        }
    }
}

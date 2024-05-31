using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GrpChallengeWk4
{
    internal static class Program
    {
        static int starting = 7;
        static int[] chocolates = { 9,2,4,8 };  //lowest 2 = 6
        static int[] chocolates2 = { 8,4,5,6 }; //lowest 2 = 9
        static string num1 = "51230100";
        static string num2 = "0051230100";
        static string num3 = "512301";

        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1: Buying chocolates\n");

            
            Console.WriteLine(CheapestChocolates(starting, chocolates)); // returns 1
            Console.WriteLine(CheapestChocolates(starting, chocolates2)); // returns 7



            Console.WriteLine("\nProblem 2: Trim trailing zeros\n\nUsing string functions:\n");

            Console.WriteLine(num2.TrimEnd('0'));                   // using string function
            Console.WriteLine(num3.TrimEnd('0')); 

            Console.WriteLine("\nUsing created functions:\n");      // using created while functions
            
            Console.WriteLine(TrimTrailingZerosWhileOriginal(num2));
            
            Console.WriteLine(TrimTrailingZerosWhile(num2,'0')); 
            Console.WriteLine(num2.TrimTrailingZerosWhile2('0'));
            
            Console.ReadKey();
        }


        public static int CheapestChocolates(int funds, int[] options)
        {
            
            Array.Sort(options);                        
            return (options[0] + options[1]) > funds ? funds : funds - (options[0] + options[1]);                               // returrns remainder

        }

        public static int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            var cur = prices[0] + prices[1];
            return cur > money ? money : money - cur;
        }





        public static string TrimTrailingZerosWhileOriginal(string num)
        {
            char[] charArray = num.ToCharArray(); // Convert the string to a character array
            int endIndex = charArray.Length - 1; // Start from the last index of the array


            // Loop to find the last non-zero character
            while (endIndex >= 0 && charArray[endIndex] == '0')
            {
                endIndex--; // Move to the previous character

            }
            // Create a new string up to the last non-zero character    
            return new string(charArray, 0, endIndex + 1);
        }
        public static string TrimTrailingZerosWhile(string s, char c)
        {
            
            
            while(s[s.Length - 1] == c)          //checks last character until it is not a 0
                s=s.Remove(s.Length - 1,1);             //removes trailing 0 at index 
                
            
            return s;
        }
        public static string TrimTrailingZerosWhile2(this string num, char c)
        {
            while (num[num.Length-1]==c)          //checks last character until it is not a 0
                num = num.Substring(0, num.Length - 2);  //returns substring without trailing 0
          
            
            return num;
        }
    }
}

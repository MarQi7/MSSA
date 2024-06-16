using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Primes
{
    internal class Program
    {
        static bool isPrime(int x)
        {
            if (x <= 0) return false;
            if (x == 2) return true;
            if (x%2 == 0) return false;
            for (int i = x/2; i > 2; i--)
            {
                if ((x % i) == 0)
                    return false;
            }    
        

            return true;
        }
        static string AllPrimes(int n)
        {
            int count = 0;
            string primes = "";
            for (int i = 1; count < n+1; i++)
            {
                if (isPrime(i))
                {
                    primes += i + " ";
                    count++;
                }
            }
            return primes;
        }
        static void Main(string[] args)
        {
            Console.Write($"-Prime Verification-".PadLeft(20, '-'));
            Console.Write("\nEnter the number you wish to check: ");
            Console.WriteLine(isPrime(int.Parse(Console.ReadLine())));
            Console.ReadKey();

            Console.Write("\nEnter the number of primes you wish to see: ");
            Console.WriteLine(AllPrimes(int.Parse(Console.ReadLine())));
            Console.ReadKey();

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringFunctions
{
    internal class RegExPractice
    {
        
        public static void RegExM()
        {
        input:
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (ContainsDigits(name))
            {
                Console.WriteLine("Enter letters only...");
                goto input;
            }
            //Console.ReadKey();


            retry:
            Console.WriteLine("Please enter your your email: example@yahoo.com");
            string eemail = Console.ReadLine();
            if (CheckEmail(eemail))
            {
                Console.WriteLine("Your email has been registered.\n");
                
            }
            else
            {
                Console.WriteLine("Please re-enter a valid email...");
                goto retry;
            }

        }
        static bool CheckEmail(string email)
        {
            string emailpattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; //starts with '^' >> [^@\s] +
            return Regex.IsMatch(email, emailpattern); 
        }
        static bool ContainsDigits(string s)
        {
            return Regex.IsMatch(s, @"\d");
        }
    }
}

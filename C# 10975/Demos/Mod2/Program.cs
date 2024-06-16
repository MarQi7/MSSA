using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mod2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assignment 1.1 Pt. 1
            
            int i; //32bit
            char c; 
            string s;
            string name;
            float age;
            
            string address;
            string answer;


            Console.WriteLine("Part 1: Variables and user input\n\n");
            Console.WriteLine("Hello! You're free to create a profile and use the math functions.");
            Console.WriteLine("So let's start with the basics.... Who are you?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nHow old are you?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            try
            {
                age = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.WriteLine("Please only use an integer or decimal number.");
                age = Convert.ToSingle(Console.ReadLine());
              
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\nOkay, so your name is ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" and you're ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(age);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" years old.\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What is your address?");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            address = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nSo you're currently located at: " + address +".\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Okay... Let's move on. Press any key to continue...");
            Console.ReadKey();




            // Pt. 2

            Console.WriteLine("\n\n\nPart 2: Basic numeric types min/max value\n\n");
            int num;
            Console.WriteLine("The minimum value of an int is: " + int.MinValue);
            Console.WriteLine("The maximum value of an int is: " + int.MaxValue);
            float fnum;
            Console.WriteLine("\nThe minimum value of an float is: " + float.MinValue);
            Console.WriteLine("The maximum value of an float is: " + float.MaxValue);
            decimal dnum;
            Console.WriteLine("\nThe minimum value of an decimal is: " + decimal.MinValue);
            Console.WriteLine("The maximum value of an decimal is: " + decimal.MaxValue);
            double bnum;
            Console.WriteLine("\nThe minimum value of an double is: " + double.MinValue);
            Console.WriteLine("The maximum value of an double is: " + double.MaxValue);
            Console.WriteLine("\nPress any key to continue..."); 
            Console.ReadKey();

            // Pt. 3
            Console.WriteLine("\n\n\nPart 3 & 4: Using math with user input\n\n");
            Console.WriteLine("Let's test the sum program.... Please enter 2 numbers, one at a time. \n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nOkay, your sum is: " + (num1 + num2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nAlright, now let's test the division program.... Please enter 2 numbers, one at a time. \n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nOkay, your result is: " + (num3 / num4));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nWell... this is the end of our profile demo, thank you for trying it out.");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2
{
    // doc string - add functions to class
    internal class Program
    {
        static void Main(string[] args)
        {
            var temp = 9;
            Console.Write("Enter a name: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.BackgroundColor = ConsoleColor.DarkCyan;


            var name =Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.Black;
            DisplayGreeting(name);
            Console.WriteLine("Enter 2 numers: ");
            int num1=int.Parse(Console.ReadLine()); 
            int num2=int.Parse(Console.ReadLine());
            var sum=AddNums(num1,num2);
            Console.WriteLine($"The sum is : {sum}");
            Console.ReadKey();
        }
        static int AddNums(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum; 
        }
        static void DisplayGreeting(string nameOfPerson) 
        { 
        Console.WriteLine($"Welcome {nameOfPerson}");
        Console.WriteLine($"Hi, How are you {nameOfPerson}?");
        }
    }
}

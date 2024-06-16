using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {

        static int addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static int subtraction(int num1, int num2)
        {
            return (num1 - num2);
        }
        static int multiplication(int num1, int num2)
        {
            return (num1 * num2);
        }
        static float division(float num1, float num2)
        {
            return num1 / num2;
        }
        static string is_equal(int num1, int num2)
        {
            string x;
            if (num1 != num2)
            {
                x = $"\n{num1} and {num2} are not equal";
            }
            else
            {
                x = $"\n{num1} and {num2} are equal"; 
            }
            return x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter two numbers to test for equality!");
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine()); 

            if (num1 != num2)
            {
                Console.WriteLine($"\n{num1} and {num2} are not equal");
            }
            else
            {
                Console.WriteLine($"\n{num1} and {num2} are equal");
            }
            Console.WriteLine("\n\nLet's check one more set of numbers!");
            
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());

            if (num1 != num2)
            {
                Console.WriteLine($"\n{num1} and {num2} are not equal");
            }
            else
            {
                Console.WriteLine($"\n{num1} and {num2} are equal");
            }

            Console.Write("\n\nThe first 10 natural numbers are :\n1 2 3 4 5 6 7 8 9 10\nThe Sum is: ");
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum+=(i+1);
            }
            Console.WriteLine($"{sum}");

            
            char choice = 'y';
            while (choice == 'y')
            {
                Console.WriteLine("\n\nHello! Please enter the function you would like to use: \n[1] Addition \n[2] Subtraction \n[3] Multiplication \n[4] Division\n");
                
                string option = Console.ReadLine();
                Console.WriteLine("\nPlease enter 2 numbers");
                num1 = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());
                switch (option)
                {


                    case "1":
                        //Console.WriteLine("\n[Addition] Please enter 2 numbers");

                        Console.WriteLine($"\nThe sum of {num1} and {num2} is {addition(num1,num2)}.");
                        break;
                    case "2":
                        //Console.WriteLine("\n[Subtraction] Please enter 2 numbers");

                        Console.WriteLine($"\nThe difference of {num1} and {num2} is {subtraction(num1,num2)}.");
                        break;
                    case "3":
                        //Console.WriteLine("\n[Multiplication] Please enter 2 numbers");

                        Console.WriteLine($"\nThe product of {num1} and {num2} is {multiplication(num1,num2)}.");
                        break;
                    case "4":
                        //Console.WriteLine("\n[Division] Please enter 2 numbers");

                        Console.WriteLine($"\nThe quotient of {num1} and {num2} is {(int)division(num1,num2)} or {division(num1,num2)}.");
                        break;
                    default:
                        Console.WriteLine("\nSorry, that's not an option.");
                        break;


                }
                Console.WriteLine("\nWould you like to use another function? Enter [y] or [n]");
                choice = Convert.ToChar(Console.ReadLine().ToLower());
            }
            Console.WriteLine("\n\nThank you for trying this product. Press any key to exit...");
            Console.ReadKey();  
        }
    }
}

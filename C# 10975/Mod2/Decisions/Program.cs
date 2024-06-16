using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static char CalculateGrade(int score)
        {
            if (score >= 0)
            {
                if (score >= 60)
                {
                    if (score >= 70)
                    {
                        if (score >= 80)
                        {
                            if (score >= 90)
                            {
                                return 'A';
                            }
                            return 'B';
                        }
                        return 'C';
                    }
                    return 'D';
                }
                return 'E';
            }
            else
            {
                return 'E';
            }
        }
        static string FavColor(string color)
        {
            
            switch (color)
            {
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Great choice!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("Great choice!");
                    
                    break;

                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Great choice!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Great choice!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great choice!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Great choice!");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "purple":
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("We don't have purple...");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "pink":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("We don't have pink...");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                
                    
            }
            return null;

        }
        
        static void Main(string[] args)
        {
            Console.Write("Please enter your age: ");
            int age=int.Parse(Console.ReadLine());
            if (age < 21)
            {
                Console.WriteLine($"You are too young to drink alcohol kid.");
            }
            char choice = 'y';
            while (choice == 'y')
            {


                string color;
                Console.WriteLine("Select your favorite color from these options : Black, Red, Green, Blue, Purple, Yellow, Pink, White");
                color = Console.ReadLine().ToLower();
                if (color != null) 
                    Console.WriteLine(FavColor(color));
                else
                   Console.WriteLine("You didn't enter anything...");
                Console.WriteLine("Do you want to play again?");
                choice = Convert.ToChar(Console.ReadLine().ToLower());

            }
            Console.ReadKey();  
        }
        


    }
}

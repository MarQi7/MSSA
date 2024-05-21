using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.R

namespace StringFunctions
{
    internal class Matrix
    {
        static int Mainframe(int m)
        {
            
            return;
        }
        public static void Matrixer()
        {
            Console.WriteLine("Let's create a matrix visualization with text!");
            choice:
            Console.WriteLine("Please choose an option for the matrix size:\n[2]\n[3]\n[4]");
            var choice = 0;
            int.TryParse(Console.ReadLine(), out choice);
         
            switch (choice)
            {
                case 2:
                    Console.WriteLine(Mainframe(choice));
                    break;
                case 3:
                    Console.WriteLine(Mainframe(choice));
                    break;
                case 4:
                    Console.WriteLine(Mainframe(choice));
                    break;
                default:
                    Console.WriteLine("Please enter one of the given options...\n");
                    Console.ReadKey();
                    goto choice;

            }
        

        }
    }
}

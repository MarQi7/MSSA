using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs
{
    internal class TempReader
    {
        public static void Temp()
        {
            restart:
            Console.Write("\nPlease input the current or expected temperature for the day in farenheit: ");
            int temp = int.Parse(Console.ReadLine());
            switch (temp)
            {
                case int n when n < 11:
                    Console.WriteLine("\nIt's freezing weather.");
                        break;
                case int n when n < 21:
                    Console.WriteLine("\nIt's very cold weather.");
                        break;
                case int n when n < 36:
                    Console.WriteLine("\nIt's cold weather.");
                        break;
                case int n when n < 51:
                    Console.WriteLine("\nIt's kind of cold.");
                        break;
                case int n when n < 66:
                    Console.WriteLine("\nIt's normal weather.");
                        break;
                case int n when n < 81:
                    Console.WriteLine("\nIt's very hot.");
                        break;
                case int n when n > 80:
                    Console.WriteLine("\nTake precaution while outside... It's too hot.");
                    break;
            }
            Console.WriteLine("\nWould you like to enter another temperature? [Y]/[N]");
            if (Console.ReadLine().ToUpper() =="Y")
                goto restart;
            Console.WriteLine("\nPress any key to continue...\n");
            Console.ReadKey();  
        }
    }
}

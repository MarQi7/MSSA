using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    internal class TipCalculator
    {
        public static decimal bill;
        public static int choice;
        public static void Bill()
        {
            Console.WriteLine("\n\n**Calculate the total bill**");
            Console.Write("\nPlease enter the initial bill amount (ex. 22.55): ");
            bill = decimal.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease choose your tip amount: \n[1] %10 \n[2] %15 \n[3] %20 \n[4] custom");
            choice = int.Parse(Console.ReadLine());
            Tip();
            Console.WriteLine(($"\nYour total bill is: {bill:C}").PadLeft(35,'*'));
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        private static void Tip()
        {
            switch (choice)
            {
                case 1: 
                    bill += (bill * .10m);
                    break;
                case 2:
                    bill += (bill * .15m);
                    break;
                case 3:
                    bill += (bill * .2m);
                    break;
                case 4:
                    Console.Write("Enter a custom amount (ex. 30): ");
                    bill += (bill * (decimal.Parse(Console.ReadLine())/100m));
                    break;
            }
        }

    }
}

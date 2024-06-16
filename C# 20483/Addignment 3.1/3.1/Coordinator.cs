using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._1
{
    internal class Coordinator
    {
        static private void QBlock()
        {
            
            string lines = $@"                      |                      ";
            string upperQ = $@"          Q2          |          Q1          ";
            string lowerQ = $@"          Q3          |          Q4          ";
            string between = "---------------------------------------------";
            for (int i = 0; i < 8; i++)
            {
                if(i==4)
                    Console.WriteLine(between);
                if(i==2)
                    Console.WriteLine(upperQ);
                if(i==7)
                    Console.WriteLine(lowerQ);
                Console.WriteLine(lines);
            }
            

        }
        public static void Quadrant()
        {
        Quadrant:
            QBlock();
            Console.Write("Enter a pair of coordinates to check the quadrant location (ex. \"3,7\" or \"-7,20\"): ");
            
            string[] tcoord = Console.ReadLine().Split(',');
            if (tcoord.Length < 2 )
            {
                Console.WriteLine("Please enter the coordinates in the correct format.");
                goto Quadrant;
            }
            (int, int) coords = (int.Parse(tcoord[0]), int.Parse(tcoord[1]));
            int result = 0;
            if (coords.Item1 < 0)
            {
                if (coords.Item2 > 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }
            else if (coords.Item2 > 0)
            {
                result = 1;
            }
            else result = 4;

            Console.WriteLine($"\nCoordinates {coords} are in quadrant {result}\n");
            
            
        }
    }
}

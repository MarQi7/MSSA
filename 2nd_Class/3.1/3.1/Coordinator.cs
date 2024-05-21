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
        public static void Quadrant()
        {
            Quadrant:
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
                    result = 1;
                }
                else
                {
                    result = 3;
                }
            }
            else if (coords.Item2 > 0)
            {
                result = 2;
            }
            else result = 4;

            Console.WriteLine($"\nCoordinates {coords} are in quadrant {result}\n");
            
            
        }
    }
}

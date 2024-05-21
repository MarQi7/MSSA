using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace CoordinateHW
{
    internal class Program
    {
        static Point P1 = new Point();
        static Point P2 = new Point();
        static int pyr = 21;
        static string MultiChart()
        {
            string chart = "";
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"{x} x {y} Multiplication Table:\n");
            int intLength = Convert.ToString(x*y).Length;
            for (int i = 1; i < x+1; i++)
            {
                string line = "";

                for (int j = 1; j < y+1; j++)
                {
                    int spaces = Convert.ToString(i*j).Length;
                    string len = string.Concat(Enumerable.Repeat(" ", (intLength+1) - spaces));
                    line += Convert.ToString((j * i) + len);
                    
                }
                chart+= line+"\n";  
            }
            return chart;
        }
        static string Odds_N()
        {
            int n = int.Parse(Console.ReadLine());
            int n_odds = 0;
            string odds = "\n";

            for (int i = 1; n_odds < n; i++)
            {
                if (i % 2 != 0)
                {
                    if (n_odds == n - 1)
                    {
                        odds += $"{i}";
                        break;
                    }
                    odds += $"{i}, ";
                    n_odds++;
                }
            }
            return odds;
        }
        static string Asterisks()
        {
            int x = int.Parse(Console.ReadLine());
            string pyramid = "";
            for (int i = 1; i < x + 1; i++)
            {
                string line = "";

                for (int j = 0; j < i; j++)
                {
                    line += "* ";

                }
                pyramid += line + "\n";
            }
            return pyramid;

        }
        static string Triangle()
        {
            int x = int.Parse(Console.ReadLine());
            string pyramid = "";
            for (int i = 1; i < x + 1; i++)
            {
                string line = "";

                for (int j = 0; j < i; j++)
                {
                    line += $"{i} ";

                }
                pyramid += $"{i * i}\t"+ line + "\n";
            }
            return pyramid;

        }
        static string TallTriangle()
        {
            int x = int.Parse(Console.ReadLine());
            int intLength = Convert.ToString(x).Length;
            string pyramid = "";
            for (int i = 1; i < x + 1; i++)
            {
                string line = "";

                for (int j = 0; j < i; j++)
                {
                    int spaces = Convert.ToString(i).Length;
                    string len = string.Concat(Enumerable.Repeat(" ", (intLength + 1) - spaces));
                    line += $"{i}" + len;

                }
                pyramid += $"{i * i}\t" + line + "\n";
            }
            return pyramid;

        }
         static string Pyramid(int x)
        {
            x = x;
            //int x = int.Parse(Console.ReadLine());
            int intLength = Convert.ToString(x).Length;
            int n_buffer = x - 1;
            string pyramid = "";

            for (int i = 1; i < x + 1; i++)
            {
                int spaces = Convert.ToString(i).Length;
                //string buffer = string.Concat(Enumerable.Repeat("  ", (n_buffer)));
                string line = string.Concat(Enumerable.Repeat(" ", (intLength-spaces))) + string.Concat(Enumerable.Repeat(" ", (n_buffer)));

                for (int j = 0; j < i; j++)
                {

                    string len = string.Concat(Enumerable.Repeat(" ", (intLength + 1) - spaces));
                    line += $"{i}" + len;

                }
                pyramid += line + "\n";
                n_buffer--;
            }
            return pyramid;

        }

        static string Password()
        {
            string pass = "N";
            pass = Console.ReadLine();
            
            return pass;
        }
        static string PointComparison(int p1, int p2)
        {
            if (p1 < p2)
            {
                string message = "P2 is to the right of P1";
                return message;
            }
            else if (p1 > p2)
            {
                string message = "P2 is to the left of P1";
                return message;
            }
            else if (p1 == p2)
            {
                string message = "P1 & P2 share the same axis";
                return message;

            }
            else
            {
                string message = "An error occurred...";
                return message;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Part 1: Coordinate comparison");
            Console.WriteLine("\nPlease enter the first set of coordinates as integers (X,Y): ");
            P1.x =  int.Parse(Console.ReadLine());
            P1.y =  int.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease enter the second set of coordinate as integers (X,Y): ");
            P2.x = int.Parse(Console.ReadLine());
            P2.y = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n{PointComparison(P1.x, P2.x)}...\nPress any key to continue\n");
            Console.ReadKey();


            //extra assignment 1 - multiplication tablechange
            Console.WriteLine("Extra Pt 1: Multiplication Table");
            Console.WriteLine("Please enter 2 numbers to create your table...");
            Console.WriteLine(MultiChart());
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            
            //extra assignment 2 - display n terms of odd numbers & their sums
            Console.WriteLine("\nExtra Pt 2: Display [n] of odd numbers");
            Console.Write("Please enter the number of odds you wish to have displayed: ");
            Console.WriteLine(Odds_N());
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            
            //extra assignment 3 - the triangle of asterisks 
            Console.WriteLine("Extra Pt 3: [*] Asterisks right angle");
            Console.Write("Please enter the height of triangle you wish to have displayed: ");
            Console.WriteLine($"{Asterisks()}");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            
            
            //extra assignment 4 - number towers
            Console.WriteLine("Extra Pt 4: [#] Numbers right angle");
            Console.Write("Please enter the height of triangle you wish to have displayed: ");
            Console.WriteLine($"{Triangle()}");
            Console.Write("\nExtra Pt.4+: Improved Triangle:\nPlease enter the height of triangle you wish to have displayed: ");
            Console.WriteLine($"{TallTriangle()}");
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            
            
            //... Hidden level (passkey: [7])

            Console.Write("Enter the correct key: [U] [3] [7] [0] [T]\n");
            if ("7" == Password())
            {
                Console.WriteLine("\n\nExtra Pt ?: Pyramids");
                Console.Write("Please enter the height of pyramid you wish to have displayed: ");
                pyr = int.Parse(Console.ReadLine());
                Console.WriteLine($"{Pyramid(pyr)}");

            }
            else
            {
                Console.WriteLine("\nNot quite...");
                Console.ReadKey();
            }
            Console.WriteLine("Press any key to terminate...");
            Console.ReadKey();
        }
        
    }
}

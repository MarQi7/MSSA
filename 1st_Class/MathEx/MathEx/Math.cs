using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEx
{
    public class Math
    {
        public static void FindMax(decimal[] nums)
        {
            decimal max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }
            Console.WriteLine($"\t\tThe largest # of this array is: {max} @ index: {index}");
        }
        public static void FindMax(int[] nums)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }
            Console.WriteLine($"\t\tThe largest # of this array is: {max} @ index: {index}");
        }
        public static void FindMax(double[] nums)
        {
            double max = 0;
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }
            Console.WriteLine($"\t\tThe largest # of this array is: {max} @ index: {index}");
        }
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static int Add(int num1, int num2, int num3)
        {
            return (num1 + num2) + num3;
        }
        public  static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
        public static float TriangleArea(float a, float b)
        {
            return .5f * a * b;
        }
        static int SquareArea(int a)
        {
            return a * a;
        }
        static int RectangleArea(int a, int b)
        {
            return a * b;
        }

        static string ReverseArray(int[] a)
        {
            int[] b = new int[a.Length];
            int x = 0;
            for (int i = a.Length; i > 0; i--)
            {
                b[x] = a[i - 1];

                x += 1;
            }
            string message = "";
            foreach (int num in b)
            {
                message += num.ToString() + " ";
            }
            Console.Write("\nThe reverse of the array you created is: " + message);
            //Array.ForEach(b, Console.Write);
            return null;
        }

        static int[] CreateArray(int a)
        {
            int[] x = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.Write("Please enter the next element: ");
                x[i] = int.Parse(Console.ReadLine());
            }
            string message = "";
            foreach (int num in x)
            {
                message += num.ToString() + " ";
            }
            Console.Write("\nThe array you created is: " + message);
            return x;
        }

        public static double Divide(double x, double y)
        {
            if (y==0)
                return x;
            else return x / y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }

        static int parsed()
        {
            int x;

            int.TryParse(Console.ReadLine(), out x);

            return x;
        }
        /*static void Main(string[] args)
        {
            while (true)
            {
            loop:
                Console.WriteLine("Hello! Please choose which area you want to calculate:\n[1] Triangle \n[2] Square \n[3] Rectangle\n");
                int option;
                string message = "\nPlease enter the base and the height. [only 1 # for squares]";
            fail:
                try
                {
                    option = int.Parse(Console.ReadLine());
                    if (option < 1 || option > 3)
                        throw new Exception("Out of range...");

                }
                catch (Exception e)
                {
                    Console.Write($"\n{e}\n\nPlease enter [1],  [2] or [3]: ");
                    goto fail;
                }
                switch (option)
                {
                    case 1:
                        Console.WriteLine(message);
                        Console.WriteLine($"\nThe area of the triangle is: {TriangleArea(parsed(), parsed())}");
                        break;
                    case 2:
                        Console.WriteLine(message);
                        Console.WriteLine($"\nThe area of the square is: {SquareArea(parsed())}");
                        break;
                    case 3:
                        Console.WriteLine(message);
                        Console.WriteLine($"\nThe area of the rectangle is: {RectangleArea(parsed(), parsed())}");
                        break;
                }
            question:
                Console.Write("\nWould you like to calculate another area? [y] / [n]: ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                    goto loop;
                else if (answer == "n")
                    break;
                else
                    Console.WriteLine("\nThat's not an option... ");
                goto question;

            }
        part2:
            Console.Write("\n\nPart 2: creating an array\nPlease enter the # of elements you wish to store: ");
            try
            {
                Console.Write($"\n{ReverseArray(CreateArray(int.Parse(Console.ReadLine())))}\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter an #.");
                goto part2;
            }

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }*/
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int row = 2;
            int col = 2;
            int[] sample1 = {  1 , 2 ,  3 , 4  };
            int[] sample2 = {  5 , 6 , 7 , 8  };

            Matrixes m1 = new Matrixes();
            Matrixes m2 = new Matrixes();
            m1.CreateMatrix(row,col,sample1);
            m2.CreateMatrix(row,col,sample2);
            
            Matrixes m3 = m1 + m2;
            
            Circle c1 = new Circle();
            Circle c2 = new Circle();   
            c1.Radius = 5;
            c2.Radius = 7;

            Console.WriteLine("Assignment 3.2: ");
            

            Console.WriteLine("\nPart 1: Creating a visual Matrix");
            Visualizer.CreateMatrix();
            
            Console.WriteLine("\nPart 2: Matrix Math");
            Console.WriteLine("The first matrix:");
            m1.BuildVisual();
            Console.WriteLine("The second matrix:");
            m2.BuildVisual();
            Console.WriteLine("The combined matrix:");
            m3.BuildVisual();

            Console.WriteLine("\nPart 3: Overload Operators");
            Console.WriteLine($"The area of the first circle: {c1.CalculateArea()}");
            Console.WriteLine($"The area of the second circle: {c2.CalculateArea()}");
            Console.WriteLine($"The sum of the area of the circles: {(c1+c2).CalculateArea()}");
            Console.WriteLine($"The difference of the area of the circles: {(c2-c1).CalculateArea()}");


            int[] nums = new int[4];
            Console.WriteLine("\nPart 4: Sum & Average Calculator");
            Console.Write("Enter the first number: ");
            nums[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            nums[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            nums[2] = int.Parse(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            nums[3] = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum: {AvgSum.Sum(nums)}\nThe average: {AvgSum.Average(nums)}\n");

            Console.WriteLine("\nPart 5: ~IndexOf Function");
            int[] s1 = { 1, 5, 3 };
            int[] s2 = { 9, 8, 3 };
            int[] s3 = { 1, 2, 3 };
            Console.Write($"Searching through index {IndexSearch.showSearch(s1)} for 5: ");
            Console.WriteLine(IndexSearch.Find(s1,5));
            Console.Write($"Searching through index {IndexSearch.showSearch(s2)} for 3: ");
            Console.WriteLine(IndexSearch.Find(s2, 3));
            Console.Write($"Searching through index {IndexSearch.showSearch(s3)} for 4: ");
            Console.WriteLine(IndexSearch.Find(s3, 4));

            Console.Write("\n\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}

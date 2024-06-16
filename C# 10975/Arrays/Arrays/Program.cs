using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] nums2 = new int[6];
            float[] nums3 = { 6.6f, 4.34f };
            

            for (int i = 0; i < nums2.Length; i++)
            {
                nums2[i] = nums[i+1];
                Console.WriteLine(nums2[i]);
            }

           
            Console.WriteLine(nums2.Max());


            int[] scores;
            Console.Write("\n\nHow many scores do you want to enter?  ");
            scores = new int[Int32.Parse(Console.ReadLine())];
            Console.WriteLine("\nPlease enter the scores.\n");
            for (int i = 0;i < scores.Length; i++)
            {
                Console.Write($"Score #{(i+1)}: ");
                scores[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine($"Score #{(i + 1)}: {scores[i]}");
            }
            string[] names = { "King", "Conquerer", "Fighter" };
            Array.Sort(names);

            Console.Write("Names in sorted order: ");

            foreach(var name in names)
            {
                Console.Write($"{name.ToUpper()} ");
            }
            int total=0;
            foreach(var num in scores)
            {
                total+= num;
            }
            Console.WriteLine("\n\n"+total);
            Console.ReadKey();


        }
    }
}

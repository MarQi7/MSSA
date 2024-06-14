using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Interpolationdemo
{
    internal class BubbleSort
    {
        public static void Bubbled(int[] nums)
        {
            bool loop = true;
            bool swapped = false;
            int current = 0;
            int loopsize = nums.Length;
            StringBuilder sb = new StringBuilder();

            while (loop == true)
            {
                int temp = 0;
                
                if (current < loopsize - 1) 
                    if (nums[current] > nums[current+1]) 
                    { 
                        temp = nums[current];
                        nums[current] = nums[current+1];
                        nums[current+1] = temp;
                        swapped = true;
                    }
                
                current++;

                if (current == loopsize - 1)
                    if (swapped == true)
                    {
                        loopsize--;
                        current = 0;
                    }
                    else loop = false;

                if (current == loopsize)
                    break;
            }

            sb.Append("[");
            foreach(int i in nums)
            {
                sb.Append(i + ",");
            }
            sb.Remove(sb.Length-1,1); 
            sb.Append("]");
            Console.WriteLine(sb.ToString());

        }   // Sorts --> [ 131, 20, 215, 2, 50 ]  --> [ 2, 20, 50, 131, 215 ]
            //  n*(n-1)/2 @ worst case ?--> (O)n^2
        public static void BubbleSortN2(int[] nums)
        {
            int temp = 0;

            for (int pass = nums.Length - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        temp = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = temp;
                    }
                }
            }
        }
    }
}

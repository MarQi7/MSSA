using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Challenge_Lab
{
    internal class ArrayFuncs
    {
        public static int MissingNo(int[] nums)
        {
            Array.Sort(nums);
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }

            return nums.Length;
        }

        
        public static int FoundOne(int[] nums,Dictionary<int,int> count)
        {
            
            int found = nums.Length;
            int min = 0;
            foreach(int i in nums)
            {
                if (count.ContainsKey(i)) count[i] += 1;
                else count[i] = 1;
            }
            

            foreach(KeyValuePair<int,int> pair in count)
            {
                if (pair.Value < found)
                {
                    min = pair.Key;
                    found = pair.Value;
                }
            }

            return min;
        }


    }
}

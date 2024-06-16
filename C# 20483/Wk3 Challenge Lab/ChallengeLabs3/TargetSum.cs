using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs3
{
    internal class TargetSum
    {
        public static string TwoSum(int[] nums, int target) // from leetcode lol
        {
            int[] rn = new int[2];
            for (int num1 = 0; num1 < nums.Length; num1++)
                for (int num2 = num1 + 1; num2 < nums.Length; num2++)
                    if (nums[num1] + nums[num2] == target)
                    {
                        rn[0] = num1;
                        rn[1] = num2;
                        break;
                    }
            string result = $"[{rn[0].ToString()},{rn[1].ToString()}]";

            return result;
        }

        public static string TwoSumNoLoop(int[] nums, int target)
        {
            int[] rn = new int[2];

            //using a dictionary for this function/.??
            // looking through 2 numbers for a sum match...
            // key, val - sure they are locked in a dict, but how do you go through all of them without a douhle loop? 
            // 
        }
    }
}

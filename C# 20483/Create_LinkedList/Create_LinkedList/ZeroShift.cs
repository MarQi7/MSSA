using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_LinkedList
{
    internal class ZeroShift
    {
        public static string ShiftRight(int[] nums)
        {
            StringBuilder sb = new StringBuilder(); // O(n^2)
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = 0;
                
                while (i > 0 && ((nums[i-1] > nums[i] && nums[i] != 0) ||  (nums[i-1]==0 && nums[i] != 0)))
                {
                    temp = nums[i-1];
                    nums[i-1] = nums[i];
                    nums[i] = temp;
                    i--;
                }
            }
            sb.Append("[");
            foreach (int i in nums)
                sb.Append($"{i},");
            sb.Remove(sb.Length - 1,1);
            sb.Append("]");
            return sb.ToString();
        }

        public static string ShiftLinear(int[] nums)
        {
            StringBuilder sb = new StringBuilder();

            for(int i = nums.Length-1; i > 0; i--)
            {
                int temp = 0;
                if (i < nums.Length - 2)
                {
                    if(nums[i] == 0 && nums[i + 1] != 0)
                    {
                        temp = nums[i + 1];
                        nums[i + 1] = nums[i];
                        nums[i] = temp;
                        i++;
                    }
                }
            }

            sb.Append("[");
            foreach (int i in nums)
                sb.Append($"{i},");
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }

        public static string ShiftByCountZero(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
            }

            for (int i = 0; count > 0; i++)
            {
                int temp = 0;
                int last = nums.Length - 1;
                if (nums[i] == 0 && nums[last] != 0)
                {
                    temp = nums[i];
                    nums[i] = nums[last];
                    nums[last] = temp;
                    last--;
                    count--;
                }
                else if (nums[i] == 0 && nums[last - 1] != 0)
                {
                    temp = nums[i];
                    nums[i] = nums[last];
                    nums[last] = temp;
                    last--;
                    count-=2;
                }
                else if (nums[last]==0)
                {
                    last--;
                    count--;
                }
                if (i == nums.Length - count) i=0;
            }

            sb.Append("[");
            foreach (int i in nums)
                sb.Append($"{i},");
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }
    }
}

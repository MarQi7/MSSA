using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class ProductExeption
    {
        
        public static string ProductExclusiveNums(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            int count = 0;
            int set = 0;
            int total = 1;
            int[] answer = new int[nums.Length];
            for (int i = 0; i < nums.Length * nums.Length; i++)
            {

                if (set != count)
                    total *= nums[count];

                count++;
                if (count == nums.Length)
                {
                    count = 0;
                    answer[set] = total;
                    set++;
                    total = 1;
                }
                
            }

            sb.Append("[");
            foreach (int i in answer)
            {
                sb.Append($"{i},");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }
    }
}

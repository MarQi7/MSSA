using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Distinct
    {
        public static bool DistinctIntCheck(int[] nums) 
        {
            
            return nums.Length == nums.Distinct().Count();
        }
    }
}

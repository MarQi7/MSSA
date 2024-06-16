using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs4
{
    internal class TheMode
    {
        //Math mode -frequency of appearance of an input element
        
        public static void RepeatNums(int[] nums)
        {
            
            Dictionary<int, int> Mode = new Dictionary<int, int>();
            foreach (int i in nums)
                if (Mode.ContainsKey(i))
                    Mode[i] += 1;
                else Mode.Add(i, 1);
            PrintVals(Mode);
        }

        private static void PrintVals(Dictionary<int,int> mode)
        {
            foreach(KeyValuePair<int,int> item in mode) 
            {
                Console.WriteLine($"{item.Key} occurs {item.Value} times");
            }
            
        }

    }
}

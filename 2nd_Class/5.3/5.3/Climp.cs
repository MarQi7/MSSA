using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    internal class Climp
    {

        public static void TwoStepRecurse(int n, ref int result,int steps = 0)
        {

            if (steps == n) result += 1;

            if (steps < n)
            {
                TwoStepRecurse(n, ref result, steps + 1);

            }
            if (steps < n)

                TwoStepRecurse(n, ref result, steps + 2);
               
           
        }
    }
}

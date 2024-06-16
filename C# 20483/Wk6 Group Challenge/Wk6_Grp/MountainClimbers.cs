using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_Grp
{
    internal class MountainClimbers
    {
        public static void OneTwoStep(int[] steps)
        {

            if (steps.Length == 0) Console.WriteLine("There are no stairs");
            bool started = false;
            int totalsteps = 0;
            int totalcost = 0;
            for (int i = 0; i < steps.Length; totalsteps++)
            {
                if (started == false && steps[0] > steps[1])
                {
                    i++;
                    started = true;
                }

                totalcost += steps[i];
                
                if (i < steps.Length - 2)
                {
                    int step = i;
                    if (steps[i + 1] + steps[i + 3] > steps[i + 2])
                            i+=2;
                    else i++;
                    
                    Console.WriteLine($"\nPay {steps[step]} and climb {i-step} steps to reach index {i}");
                }
                else 
                {
                    Console.WriteLine($"\nPay {steps[i]} and climb {steps.Length-i} steps to reach the top.\n");
                    Console.WriteLine($"Total cost for {totalsteps + 1} steps to the top: {totalcost}");
                    break;
                }

            }




        }
    }


}

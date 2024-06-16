using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    // a utility class containing commonly used funcitons
    // static classes cant be instantiated or inherited
    // they can only containt static members
    // compiler keeps a check on creating just 1 object of a static class ***
    // similar to Console & Math. they don't hold on to values except internally. 
    internal static class Conversions
    {
        static int PtoKg;
        static Conversions()
        {
            PtoKg = 0;

        }
        public static void PoundsToKgs(float weight)
        {
            
        }
        
    }
}

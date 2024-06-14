using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HammingWeight
{
    internal class Modulus
    {
        public static int HammingWeightR(int n, ref int binary, ref int weight)
        {

            if (n != 0)
            {
                HammingWeightR((n - (n % 2)) / 2, ref binary, ref weight);
            }

            binary = (binary * 10) + (n % 2);   
            if (n % 2 == 1) weight++;   
            Console.WriteLine(binary);  
            return weight;

        }
    }
}

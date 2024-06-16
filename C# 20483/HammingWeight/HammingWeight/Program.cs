using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HammingWeight
{
    internal class Program
    {
        static int binary = 0;
        static int weight = 0;
        static void Main(string[] args)
        {

            //Modulus.HammingWeightR(21,ref binary,ref weight);
            Console.WriteLine(Modulus.HammingWeightR(128, ref binary, ref weight));
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

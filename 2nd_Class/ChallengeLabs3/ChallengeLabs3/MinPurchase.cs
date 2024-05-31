using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs3
{
    internal class MinPurchase
    {
        //
        

        public double CheapestChocolate(double funds, double[] options)
        {
            Array.Sort(options);
            double cost= (options[0] + options[1]);
            if (cost > funds)
                return funds;

            funds -= cost;
            return funds;

        }
    }
}

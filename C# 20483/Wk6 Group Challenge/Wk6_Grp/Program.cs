using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6_Grp
{
    internal class Program
    {
        static int[] costs = { 1, 5, 100, 1, 7, 1, 100, 1, 1, 21, 41, 13, 12, 9, 100};
        static void Main(string[] args)
        {

            int[] cost = { 10, 15, 20 };
            int[] cost2 = { 1, 4, 100, 1, 1, 1, 100, 1, 1, 100, 1 };

            int result = MinCostStairs(costs);
            int result2 = MinCostStairs(cost2);

            Console.WriteLine(result);
            Console.WriteLine(result2);

            Console.WriteLine("\n");

            MountainClimbers.OneTwoStep(costs);     //need to fix the start to adjust for a rough starting point.
            
            
            Console.ReadKey();
        }

        public static int MinCostStairs(int[] cost)
        {
            int n = cost.Length;
            if (n == 0) return 0;
            if (n == 1) return cost[0];
            
            int prev2 = cost[0];
            int prev1 = cost[1];

            for (int i = 2; i < n; i++)
            {
                int current = cost[i] + Math.Min(prev1, prev2);
                prev2 = prev1;
                prev1 = current;
            }

            return Math.Min(prev1, prev2);
        }
    }
}

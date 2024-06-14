using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace Week6ChallangeLab
{
    internal class Program
    {

        static int minCostClimbingStairs(int[] cost)  // takes an array of integers cost as an input and returns an integer. static method name 
        {
            int n = cost.Length; // n stores length of cost array 
            if (n == 0) return 0;   //checks for emply array , if empty, min cost to climb is - 
            if (n == 1) return cost[0]; // if only one step recall the single input(element)of the array

            int[] Arr = new int[n + 1]; // create arry of size n+1 to store min cost
            Arr[0] = 0; // Step one array 
            Arr[1] = 0;  // step 2 

            for (int i = 2; i <= n; i++)                                                     // dynamic programing to fill array 
            {                                                                                // for loop to start array at 2 with n storing cost of array value 
                Arr[i] = Math.Min(Arr[i - 1] + cost[i - 1], Arr[i - 2] + cost[i - 2]);       // does and stores calculation for each step and compares it to the first two 
            }
            return (Arr[n]);                                                                 // returns the min result 

        }


        static void Main(string[] args)
        {
            //int[] cost = [ 10, 15, 20 ];
            //Console.WriteLine(minCostClimbingStairs(cost));

            int[] cost1 = [1, 100, 1, 1, 1, 100, 1, 1, 100, 1];
            Console.WriteLine(minCostClimbingStairs(cost1));

        }
    }
}

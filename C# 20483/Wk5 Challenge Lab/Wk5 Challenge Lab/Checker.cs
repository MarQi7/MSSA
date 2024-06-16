using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk5_Challenge_Lab
{
    internal class Checker
    {
        public static int MaxEvenOdd(int[] houses)
        {
            int even = 0;
            int odd = 0;
            for (int i = 0; i < houses.Length;i+=2)
                even += houses[i];
            for (int i = 1; i < houses.Length;i+=2)
                odd += houses[i];
            Console.WriteLine($"Even indexes: {even}\nOdd indexes: {odd}");
            return even>odd ? even:odd;
        }
        
        static int MaxMoney3(int[] Arr)
        {
            int totalMoney = 0;
            int maxIndex = Array.IndexOf(Arr, Arr.Max());
            for (int i = maxIndex % 2; i < Arr.Length; i += 2)
                totalMoney += Arr[i];
            
            return totalMoney;
        }

        static int MaxMoneyTCX(int[] Arr)
        {
            int totalMoney = 0;
            int maxIndex = 0;
            int maxVal = 0;
            for (int i = 0; i <Arr.Length;i++)
                if (Arr[i]> maxVal)
                {
                    maxVal = Arr[i];
                    maxIndex = i;
                }
                    
            for (int i = maxIndex % 2; i < Arr.Length; i += 2)
                totalMoney += Arr[i];

            return totalMoney;
        }

        public static string MaxEvenOddRecursive(int[] houses, ref int even, ref int odd, int index = 0)
        {

            if (index % 2 == 0)
                even += houses[index];
            else odd += houses[index];
            if (index != houses.Length-1)
                MaxEvenOddRecursive(houses, ref even, ref odd, index+1 );
            return even > odd ? $"Even: {even}" : $"Odd: {odd}";
        }

        /// where did this idea come from???
        public static int Robber_planning(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            int rob1 = 0;
            int rob2 = 0;

            foreach (int num in nums)
            {
                int current = Math.Max(rob1, rob2 + num);
                rob2 = rob1;
                rob1 = current;
            }

            return rob1;
        }
        static int RobHouse(int[] houses)
        {

            // Initialize variables
            int maxCurrent = 0;  // maxCurrent will store the maximum money robbed including the current house
            int maxPrevious = 0; // maxPrevious will store the maximum money robbed excluding the current house

            // Iterate through each house in the array
            for (int i = 0; i < houses.Length; i++)
            {

                // Calculate the potential sum if the current house is robbed
                int potentialSum = maxPrevious + houses[i];


                // Update maxPrevious to be the value of maxCurrent before moving to the next house
                maxPrevious = maxCurrent;

                // Update maxCurrent to be the maximum of:
                // 1. maxCurrent (if we do not rob the current house)
                // 2. potentialSum (if we rob the current house)
                maxCurrent = Math.Max(maxCurrent, potentialSum);

                Console.WriteLine($"Potential Sum: {potentialSum} \t Previous Max: {maxPrevious} \t Current Max: {maxCurrent} ");

            }

            // Return the maximum amount of money that can be robbed without alerting the police
            return maxCurrent;
        }
    }
}
        




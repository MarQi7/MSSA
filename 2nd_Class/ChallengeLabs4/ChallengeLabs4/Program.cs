using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs4
{
    internal class Program
    {
        static int[,] ints = new int[4, 5];
        static int custID = 1001;
        static string custName = "James";
        static int units = 800;
        static int[] Nums = {25,12,43,43,55,34,12,32,12};
        //static Dictionary<int, int> Mode = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            String a = "TechBeamers";
            String b = "TECHBEAMERS";
            int c;
            c = a.CompareTo(b); // -1 a precedes b, 0 a and b are the same, 1 a comes after b in sorting
            Console.WriteLine(c);

            Console.WriteLine();
            Console.WriteLine(ElectricBill.ElecBillGen(custID,custName,units));
            Console.WriteLine();
            TheMode.RepeatNums(Nums);
            Console.ReadKey();


        }
        public int BuyChoco(int[] prices, int money)
        {
            Array.Sort(prices);
            var cur = prices[0] + prices[1];
            return cur > money ? money : money - cur;
        }
    }
}

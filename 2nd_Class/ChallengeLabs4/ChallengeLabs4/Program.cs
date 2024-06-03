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
        static string bracks = "()[]{}";
        static string bracks2 = "(f)[e]sss{g}";
        static string bracks3 = "(f[e]ss}s{g}";
        //static Dictionary<int, int> Mode = new Dictionary<int, int>();
        static void Main(string[] args)
        {
            

            Console.WriteLine();
            Console.WriteLine(ElectricBill.ElecBillGen(custID,custName,units));
            Console.WriteLine();
            TheMode.RepeatNums(Nums);
            Console.WriteLine();
            Console.WriteLine(StringChecker.BracketCheck(bracks)) ;
            Console.WriteLine(StringChecker.BracketCheck(bracks2));
            Console.WriteLine(StringChecker.BracketCheck(bracks3));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExperiments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            string result = "";
            float total = 0;
            foreach(string value in values)
            {
                float num = 0;
                float.TryParse(value, out num);
                if (num > 0)
                {
                    total += num;
                    continue;
                }                    
                result += value;
                
            }
            Console.WriteLine($"Message: {result}\nTotal: {total}");
            Console.ReadKey();  



        }
    }

}

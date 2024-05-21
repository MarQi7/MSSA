using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs
{
    internal class Numbers
    {
        public static string Cust_Triangle()
        {

            Console.Write("Please enter the desired number to create your triangle: ");
            int x = int.Parse(Console.ReadLine());
            string pyramid = "";
            for (int i = 1; i < x + 1; i++)
            {
                string line = "";

                for (int j = 0; j < i; j++)
                {

                    line += $"{x} ";

                }
                pyramid = $"{line}\n" + pyramid;
            }
            return pyramid;

        }

    
        public static string Prism()
        {

            Console.Write("Please enter the desired number to create your prism (shows better with a single digit #): ");
            int x = int.Parse(Console.ReadLine());
            int xlen = x.ToString().Length;
            int spacing = (xlen+1) * x * 2 ;
            string prism_top = "";
            string prism_bottom = "";
            for (int i = 1; i < x + 1; i++)
            {
                string line = "";

                for (int j = 0; j < i; j++)
                {
                    
                    line += $"{x} ";

                }
                spacing -= xlen*2+2;
                string len = string.Concat(Enumerable.Repeat(" ", spacing ));
                prism_top = $"{line}{len}{line}\n" + prism_top;
                prism_bottom += $"{line}{len}{line}\n";
            }
            string prism = prism_top + prism_bottom;
            return prism;

        }

    }
}

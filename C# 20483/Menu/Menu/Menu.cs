using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Menu
    {
        static void Main(string[] args)
        {
            Beverages weekndMenu = new Beverages(new string[] { "Hennessy VSOP", "Bacardi CP", "Tequila Sunrise", "Moscow Mule", "Mojito" });
            for(int i = 0;i<weekndMenu.Length;i++)
            {
                Console.WriteLine(weekndMenu[i]);
            }
        }
    }
}

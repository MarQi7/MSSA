using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _5._3
{
    internal class Plants
    {

        public static bool AdjacentCheckSplit(int[] plants, int n)
        {
            string search = String.Join("", plants);
            search = search.Replace("000", "0,0");
            
            if (search.LastIndexOf(",00") == search.Length-3) n = n - 1; // accounts for the very last pot
            string[] result = search.Split(',');
            
            return result.Length > n ? true : false;

        }

        public static bool AdjacentCheckLoop(int[] plants, int n)
        {
            string search = String.Join("",plants); // Converts to "1001100001" 
            while (true)
            {
                if (search.Contains("000"))
                {
                    search = search.Substring(search.IndexOf("000") + 2);
                    plants[search.IndexOf("000")+1] =1 ;
                    n--;
                }
                else if (search.LastIndexOf("00") == search[search.Length - 2]) // accounts for last pot
                {
                    plants[plants.Length-1] =1 ;
                }
                    
                else { break; }
                                
            }
            
            return n<=0 ? true:false;

        }

        
        
    }
}

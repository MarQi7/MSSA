using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ChallengeLabs3
{
    internal class StringDigitSum
    {
       

        public static int returnSum(string str)
        {
            int total=0;
            char[] chars = str.ToCharArray();
            for(int i=0; i < chars.Length; i++)
            {
                if (char.IsDigit(chars[i]))
                {
                    total += int.Parse(chars[i].ToString());
                   
                }
            }


            return total;
        }

        public static int returnSum2(string str)
        {
            int total = 0;
            int next = 0;
            foreach(char c in str)
            {

                if(int.TryParse(c.ToString(),out next))
                {
                    total += next;
                }

            }            

            return total;
        }

     
    }
}

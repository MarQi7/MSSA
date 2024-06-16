using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace CustomExceptions
{
    internal static class StaticMethod
    {
        public static bool ContainsNumbers(this string s) //bool
        {
            return Regex.IsMatch(s, "\\d"); //bool
        } 

        public static bool CheckNum(this int i, int val)
        {
            return i > val;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs3
{
    internal class Palindrome
    {
        
        

                
        public static bool IsPalindrome(string reverseMe)
        {
            StringBuilder sb = new StringBuilder();
            string checkstring = reverseMe;
            for(int i = reverseMe.Length-1; i >= 0; i--)
            {
            sb.Append(reverseMe[i]);
            }

            return checkstring==sb.ToString();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs4
{
    //regex works with this from the example....
    internal class StringChecker
    {
        //string pairs? 
        // a code checker 0,0 -> 1,0 -> 1,1 ->reset acceptable.
        
        public static bool BracketCheck(string s)
        {
            int[] curl = { 0, 0 };
            int[] brack = { 0, 0 };
            int[] paren = { 0, 0 };
            int current = 0;
            while (curl[1] <= curl[0] && brack[1] <= brack[0] && paren[1] <= paren[0])
            {
                
                
                
                
                switch (s[current])
                {
                    case '{':
                        curl[0]++;
                        break;
                    case '}':
                        curl[1]++;
                        break;
                    case '[':
                        brack[0]++;
                        break;
                    case ']':
                        brack[1]++;
                        break;
                    case '(':
                        paren[0]++;
                        break;
                    case ')':
                        paren[1]++;
                        break;
                    default:
                        break;

                }
                current++;
                paramReset(curl);
                paramReset(brack);
                paramReset(paren);

                if (current == s.Length) break;
            }
            if (curl.Sum() > 0 || brack.Sum() > 0 || paren.Sum() > 0) return false;
            return true;
            
            
        }
        private static void paramReset(int[] x)
        {
            if (x.Sum() > 1)
            {
                x[0] = 0;
                x[1] = 0;
            }
        }
    }
    
}

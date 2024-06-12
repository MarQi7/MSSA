using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class SubStrings
    {
        public static string LastWord(string s)
        {
            s = s.Trim();
            return s.Substring(s.LastIndexOf(' ')+1);
        }
    }
}

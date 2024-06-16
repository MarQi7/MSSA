using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs3
{
    internal class RemoveSubString
    {

        public static int Remove(string caps)
        {
            for (int i = 0; i < caps.Length; i++)  // Indexes the string 
            {
                if (i != caps.Length - 1) // Makes sure not to look beyond bounds of index
                {
                    if ((caps[i] == 'A' && caps[i + 1] == 'B') || (caps[i] == 'C' && caps[i + 1] == 'D')) // looks for "AB" or "CD"
                    {

                        caps = caps.Remove(i, 2); // Removes the pair

                        i = 0; // restarts the search immediately
                    }
                }
            }
            return caps.Length;
        }


        public static int Remove2(string caps)
        {
            for (int i = 0; i < caps.Length; i++)  // Indexes the string 
            {
                if (i != caps.Length - 1) // Makes sure not to look beyond bounds of index
                {
                    if ((caps[i] == 'A' && caps[i + 1] == 'B') || (caps[i] == 'C' && caps[i + 1] == 'D')) // looks for "AB" or "CD"
                    {

                        caps = caps.Replace("AB", "").Replace("CD", "");// Removes the pair

                        i = 0; // restarts the search immediately
                    }
                }
            }
            return caps.Length;
        }


        public static int RemoveStr(string caps)
        {
            while (true)
            {
                if (caps.Contains("AB") || caps.Contains("CD"))
                {
                    caps = caps.Replace("AB", "").Replace("CD", "");
                }
                else { break; }
            }
            
            return caps.Length;
        }


        public static int RemoveXtra(string str, params string[] subs)
        {
            string[] subsStr = subs.ToArray();
            Console.WriteLine($"The initial string is \"{str}\"");
            while (true)
            {
                if (subsStr.Any(str.Contains))
                {
                    foreach (string s in subsStr)
                    {
                        str = str.Replace(s, "");
                    }
                }
                else { break; }
            }
            Console.Write($"The remainder of the string: \"{str}\" Length: ");
            return str.Length;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class IndexSearch
    {
        public static string showSearch(int[] ints)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int i in ints)
            {
                sb.Append(i.ToString()+", ");
            }
            sb.Remove(sb.Length-2,1);
            sb.Append("]");
            return sb.ToString();
        }
        public static int Find(int[] ints, int index)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == index)
                    return i;
                
            }
            return -1;
        }
    }
}

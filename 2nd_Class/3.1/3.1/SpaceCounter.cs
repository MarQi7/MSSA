using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3._1
{
    internal class SpaceCounter
    {
        public static void Spacer()
        {
            Console.WriteLine("Enter the text you wish to have checked for spaces: \n");
            string text = Console.ReadLine();
            int count = Regex.Matches(text, @" ").Count;
            int count2 = 0;
            foreach(char c in text)
            {
                if (c == ' ') count2++; 
            }

            Console.WriteLine($"There are {count2} spaces in your text...\n");

        }
    }
}

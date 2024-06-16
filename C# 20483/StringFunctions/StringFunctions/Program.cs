using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            System.String ss;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string vowelstring = new string(vowels);
            Console.WriteLine(vowelstring);
            foreach (char c in vowels)
            {
                Console.Write(c+" ");    
            }
            Console.WriteLine("\n");
            string address= string.Empty; //immutable empty string (GC - erased)
            address = "45"; //creates new address in memory
            string address2 = address; //creates a second reference to the "45" string (locks it from GC)
            address += " Ruger Street";
            address += ", Grovetown GA";
            Console.WriteLine(address);

            StringBuilder sb = new StringBuilder();
            sb.Append(address2);
            sb.Append(" Riley Lane");
            sb.Append(", Grovetown GA");
            Console.WriteLine(sb.ToString());
            
            string str123 = " -hello- ";
            Console.WriteLine(str123 + "--after trim--" +str123.Trim());

            string header = "* A Short Play. *";
            Console.WriteLine("Before trim: "+header);
            var newheader = header.Trim(new char[] { ' ' , '*', '.'});
            Console.WriteLine("After trim: "+newheader);
            Console.WriteLine(newheader.Replace(' ', '/'));

            string splitthis = "Power level, 101, Rank, 21st. Char: Megaman";
            string[] parts = splitthis.Split(new char[] { '.',':',',' });
            foreach(string part in parts)
            {
                Console.WriteLine($"{part}");
            }
            Console.WriteLine($"{parts.ToString()}");
            //
            string key = "rotor";

            string rkey = new String(key.Reverse().ToArray());
            string r2key = Convert.ToString(key.Reverse().ToArray());  //does not work
            char[] r3key = new char[0];
            for (int i = key.Length; i>0; i--) 
            {
                r3key = r3key.Append(key[i-1]).ToArray();
            }
            string r4key = new string(r3key);
            if (key == r4key)
            {
                Console.WriteLine($"{key} is a palindrome (reverse func)");
            }
            string key2 = "";

            StringBuilder keySB = new StringBuilder();
            for(int i = key.Length; i > 0; i--) 
            {
                keySB.Append(key[i-1]);
            }
            if (keySB.ToString() == key)
            {
                Console.WriteLine($"{key} is a palindrome (alt func)");
            }

            for (int i = key.Length; i > 0; i--)
            {
                key2 += key[i-1];
            }
            if (key2 == key)
            {
                Console.WriteLine($"{key} is a palindrome (SB func)");
            }
            RegExPractice.RegExM();

            Console.WriteLine();
            Console.ReadKey();  
        }
    }
}

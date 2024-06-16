using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Launcher
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(71);
            list.Add(82);
            list.Add(73);
            list.Add(4);
            list.Add(56);
            list.Add(96);
            list.Add(37);
            list.Add(68);
            list.Add(29);
            list.Add(10);

            list.Sort();

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            List<string> list2 = new List<string>();
            list2.Add("Joey");
            list2.Add("Peter");
            list2.Add("Anee");
            list2.Add("Carmen");

            list2.Sort();

            foreach(string s in list2) 
            {
                Console.WriteLine(s);
            }
            
            List<Person> Party = new List<Person>();

            Party.Add(new Person { Name = "King", ID = 22 });
            Party.Add(new Person { Name = "Monty", ID = 1 });
            Party.Add(new Person { Name = "Anthony", ID = 44 });
            Party.Add(new Person { Name = "Nichole", ID = 27 });
            Party.Add(new Person { Name = "Kim", ID = 7 });


            Party.Sort();

            foreach (var p in Party)
            {
                Console.WriteLine($"{p.Name}\t   {p.ID}");
            }

            Party.Sort(new PersonCompareIDReverse()); // uses created comparison method

            foreach (var p in Party)
            {
                Console.WriteLine($"{p.Name}\t   {p.ID}");
            }
            Console.ReadKey();

            Conversions.PoundsToKgs(2);

        }
    }
}

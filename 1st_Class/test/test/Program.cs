using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class emp

    {

        public string name;

        public string address;

        public void display()

        {

            Console.WriteLine("{0} is in city {1}", name, address);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            emp obj = new emp();

            obj.name = "Amy";

            obj.address = "new york";

            obj.display();

            Console.ReadLine();

        }

    }

}

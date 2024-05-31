using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleDLL; // imported dll must still be added to using section - does that apply to any external library? 

namespace UsingDLL 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExampleDLL.Class1 obj= new ExampleDLL.Class1();
            int x = obj.Add(3, 3);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}

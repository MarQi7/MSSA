using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeFuncs
{
    internal class Program
    {
        static int CalculateAge(DateTime DoB)
        {
            var age = DateTime.Now.Year - DoB.Year;
            if (DoB.Month > DateTime.Now.Month)
                age -= 1;
            return age;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your date of birth. ex 2024/05/19 - YYYY/MM/DD:");
            var UserDOB = Convert.ToDateTime(Console.ReadLine());
            var age = CalculateAge(UserDOB);
            Console.WriteLine($"You're {age} years old!");
            Console.ReadKey();
            //var months = ((DateTime.Now.Year*12))

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        static List<object> students = new List<object>();
        static Student myStudent = new Student();
        static object CreateStudent()
        {
            Student myStudent = new Student();
            string fname = "";
            string lname = "";
            int age = 0;
            Console.Write("Your first name: ");
            fname = Console.ReadLine();
            Console.Write("Your last name: ");
            lname = Console.ReadLine();
            Console.Write("Your age: ");
            age = int.Parse(Console.ReadLine());
            Program.myStudent.Age = age;
            Program.myStudent.FirstName = fname;
            Program.myStudent.LastName = lname;
            Program.myStudent.ID = ("#FZx000" +(students.Count+1).ToString());
         
            return Program.myStudent;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Creating your student profile:\n");
            Console.WriteLine($"Please enter the following information:\n\n");
            CreateStudent();
            students.Add(myStudent);
            Console.WriteLine($"Hello {myStudent.FirstName}! Your ID is: {myStudent.ID}");

            Console.ReadKey();

        }
    }
}

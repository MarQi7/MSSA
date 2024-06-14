using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs
{
    internal class Program
    {
        static List<char[]> grades = new List<char[]>();
        static void Main(string[] args)
        {
            
            Console.WriteLine("Challenge 1: C# temp in fahrenheit \n\n");
            TempReader.Temp();
            
            Console.WriteLine("Challenge 2: C# File copier \n\n");
            Console.WriteLine("Creating a txt file...");
            FileReader.Filer();
            FileReader.Copier();

            Console.WriteLine("Challenge 3: C# Password checker (3 attempts) \n\n");
            PasswordCheck.CreateAcct();
            PasswordCheck.CheckPW();
            
            Console.WriteLine("Challenge 4: C# Upside down number triangle ++ \n\n");
            Console.WriteLine(Numbers.Cust_Triangle());
            Console.WriteLine(Numbers.Prism());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            
            Console.WriteLine("Challenge 5: C# Read student details\n\n");
            Student student = new Student();
            student.CreateStudent();

            //grades.Add(new char[] { 'A', 'B', 'C' });
            //grades.Add(new char[] { 'B', 'B', 'C' });
            //grades.Add(new char[] { 'A', 'B', 'A' });
            //Console.WriteLine(grades[1][0]);

            Console.Write($"\n\nStudent Roll#: {student.Roll}\nName: {student.StudentFName}\n");
            student.ReturnGrades();
            student.ReturnRating();
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}

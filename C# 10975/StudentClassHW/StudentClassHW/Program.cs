using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassHW
{
    internal class Program
    {
        
        static List<char[]> grades = new List<char[]>();
        
        
        
        static void Main(string[] args)
        {
            Student student = new Student();
            student.CreateStudent();

            //grades.Add(new char[] { 'A', 'B', 'C' });
            //grades.Add(new char[] { 'B', 'B', 'C' });
            //grades.Add(new char[] { 'A', 'B', 'A' });
            //Console.WriteLine(grades[1][0]);

            Console.Write($"Student ID#: {student.StudentID}\nName: {student.StudentFName} {student.StudentLName}\n");
            Console.Write($"Student Grades\n");
            Console.WriteLine($"Math: {student.Math}\nScience: {student.Science}\nEnglish: {student.English}");
            Console.ReadKey();
        }
    }
}

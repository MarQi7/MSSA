using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ChallengeLabs
{
    internal class Student
    {
        private int student_id;
        private int roll;
        public int Roll { get { return roll; } }
        public int StudentID { get { return student_id; } }

        private string studentFName;
        public string StudentFName { get { return studentFName; } }

        private int[] grades = new int[0];

        private double[] rating= new double[0]; 

        public void CreateStudent()
        {
            Random ID = new Random();
            Console.Write("Enter the students Roll#: ");
            roll = int.Parse(Console.ReadLine());
            Console.Write("Enter the students first name: ");
            studentFName = Console.ReadLine();
            Console.Write("Enter the students grade for Physics: ");
            AddGrades(int.Parse(Console.ReadLine()));
            Console.Write("Enter the students grade for Chemistry: ");
            AddGrades(int.Parse(Console.ReadLine()));
            Console.Write("Enter the students grade for Computer Application: ");
            AddGrades(int.Parse(Console.ReadLine()));
            student_id = 000000 + ID.Next(0, 2121);
            
            AddMarks();
        }
        private void AddGrades(int y)
        {
            grades = grades.Append(y).ToArray();
        }
        private void AddMarks()
        {
            int marks = 0;
            foreach (int g in grades)
            {
                marks += g;
            }
            rating = rating.Append(marks).ToArray();
            Console.Write($">>> marks : {marks} & len of grades: {grades.Length}");
            rating = rating.Append((double)marks/(double)grades.Length).ToArray();

        }
        private string GradingDivision()
        {
            switch(rating[1])
            {
                case double n when n > 79:
                    return "First";
                case double n when n > 40:
                    return "Second";
                case double n when n > 15:
                    return "Third";
                case double n when n > 0:
                    return "Fourth";
                default:
                    return "???";
            }
        }
        public void ReturnGrades()
        {
            Console.WriteLine($"Marks in Physics: {grades[0]}\nMarks in Chemistry: {grades[1]}\nMarks in Computer Application: {grades[2]}\n");
        }
        public void ReturnRating()
        {
            Console.WriteLine($"Total Marks = {rating[0]}\nPercentage = {rating[1]/100:P}\nDivision: {GradingDivision()}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassHW
{
    internal class Student
    {
        private int student_id;
        public int StudentID { get { return student_id; } }
        
        private string studentFName;
        public string StudentFName { get {  return studentFName; } }

        private string studentLName;
        public string StudentLName { get { return studentLName; } }
        public char Math { get { return studentGrades[0]; } }
        public char Science { get { return studentGrades[1]; } }
        public char English { get { return studentGrades[2]; } }

        private char[] studentGrades = new char[0];
        //public string StudentGrades { get {  } }

        public void CreateStudent()
        {
            Random ID = new Random();
            Console.Write("Enter the students first name: ");
            studentFName = Console.ReadLine();
            Console.Write("Enter the students last name: ");
            studentLName = Console.ReadLine();
            Console.Write("Enter the students grade for Science: ");
            AddGrades(Convert.ToChar(Console.ReadLine()));
            Console.Write("Enter the students grade for Math: ");
            AddGrades(Convert.ToChar(Console.ReadLine()));
            Console.Write("Enter the students grade for English: ");
            AddGrades(Convert.ToChar(Console.ReadLine()));
            student_id = 000000+ID.Next(0, 2121);

            
        }
        private void AddGrades(char y)
        {
            studentGrades = studentGrades.Append(y).ToArray();
        }


    }
}

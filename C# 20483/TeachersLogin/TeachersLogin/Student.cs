using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersLogin
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public grade Sci { get; set; }
        public grade Tech { get; set; }
        public grade Eng { get; set; }
        public grade Math { get; set; }



         
        public enum grade
        {
            N=0,
            A=1,
            B,
            C,
            D,
            E
        }

        public double GPA { get { return calculateGPA(); } }
        
        private double calculateGPA()
        {
            grade[] Grades = { Tech, Math, Eng, Sci };
            double total = 0;
            foreach (grade g in Grades)
            {
                
                switch (g)
                {
                    case grade.A: 
                        total += 4.00;
                        break;
                    case grade.B:
                        total += 3.00;
                        break;
                    case grade.C:
                        total += 2.00;
                        break;
                    case grade.D:
                        total += 1.00;
                        break;
                    case grade.E:
                        total += 0.00;
                        break;
                }
            }
            return  total / 4;
        }
    }
    
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public int Age { get; set;}
        private string id { get; }
        private string[] StudentAddress { get;}
        public string[] studentAddress 
        {
            get
            {
                return StudentAddress; // need a string return function for an array
            }
            set
            {
                //pull data from user input & ass to private address


            }
        }
        public string Major {  get; set; }
        public string[] Schedule {  get; set; }
        public float GPA { get; set; }

    }
}

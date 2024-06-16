using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    enum Department
    {
        IT=1,
        Finance,
        HR,
        Marketing
    }
    
    internal struct Employee
    {
        public int EID {  get; set; }   
        public string Name { get; set; }
        public int Salary {  get; set; }
        public Department Dept { get; set; }




    }

}

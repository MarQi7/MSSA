using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistrar
{
    enum MoA
    {
        January=1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    enum StudentGrade
    {
        A=1,
        B,
        C,
        D,
        E,
        F
    }
    internal struct Students
    {
        public int Id {  get; set; }
        public string FName {  get; set; }
        public string LName {  get; set; }
        public string Addresss { get; set; }
        public MoA Admission { get; set; }
        public StudentGrade Grade { get; set;}

    }
}

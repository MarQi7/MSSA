using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Beverages
    {
        private string[] beverages;

        public Beverages(string[] beverages)
        {
            this.beverages = beverages;
        }
        public int Length {  get { return beverages.Length; } }

        public string this[int index]
        {
            get { return beverages[index]; }
            set { beverages[index] = value;}
        }
    }
}

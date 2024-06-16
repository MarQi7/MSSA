using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Food
    {
        private List<string> menus; //dynamic list
        public Food(List<string> menus)
        {
            this.menus = menus;
        }

        public int Length { get { return menus.Count; } }
        public string this[int index]
        {
            get { return this.menus[index]; }
            set { this.menus.Add(value); } //add dynamically instead of to fixed preset positions
        }
    }
}

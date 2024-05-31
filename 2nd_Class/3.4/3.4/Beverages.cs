using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    internal abstract class Beverages
    {
        ///hot or iced
        ///ice / no ice
        ///frozen // 
        ///update submenu based on first choice... hot/iced/frozen
        ///list class / dict class data form window. take orders
        ///extra- new page where you fill orders/ % of correctness, tip etc, graded for performance.
        enum container
        {
            bottle=1,
            can,
            cup,
            glass,
            mug
        }
        
        enum temp
        {
            hot=1,
            cold,
            iced,
            frozen
        }
        public bool Alcoholic;
        

        public string Name;
        
        //public abstract void OrderNum();

        
    }
}

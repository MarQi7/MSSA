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
        public bool Alcoholic { get; set; }
        protected int id;
        
        public string Name { get; set; }
        public virtual void SetBaseTemp()
        {
            // what would I use this for? I need better examples.
            // public override void VirtualMethod(){
            //      base.VirtualMethod() + additional instruction .. thats how
            //}
        }
        public abstract double CalculatePrice();
        public abstract void Create(); // must be overridden, this is how its created here. no logic added. 
        // the accessability is related to one class being internal because it gives access to inacessable methods.
        // the base class has to have higher accessability than the derived class. 
        // 
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    enum sweetened              //  Enums are outside the struct or class
    {
        none = 0,
        splenda,
        sugar,
        caneSugar,
        honey,
        syrup
    }

    enum flavor
    {
        none=0,
        vanilla,
        mocha,
        matcha,
        pumpkinSpice
    }

    enum roast
    {
        light = 0,
        breakfast,
        medium,
        dark,
        bold,
        intense
    }

    enum espresso
    {
        none = 0,
        one,
        two,
    }

    enum mix
    {
        none = 0,
        cream,
        sweetCream,
        skimMilk,
        soyMilk,
        almondMilk,
        wholeMilk,
    }
    internal class Coffee : Beverages
    {


        //checkbox toppings\/
        // none, chocolate, caramel, whipped cream, nuts, graham
        

        
        //public string Description { get; set; }
        public sweetened Sweetened { get; set; }

        public roast Roast { get; set; }
        public espresso Shots { get; set; }
        public mix Mixture { get; set; }

        public override double CalculatePrice()
        {
            base.id += 1;
            return id;
        }
        //public sealed override void Create() would stop override for subclasses. can only use as is.
        public override void Create()
        {

            base.id += 1;
            
        }
        public override void SetBaseTemp()
        {
            base.SetBaseTemp();
        }

    }
    sealed class Espresso : Coffee // cannot further inherit espresso
    {

    }

}

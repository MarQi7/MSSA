using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    enum roast
    {
        Light = 1,
        Medium,
        Dark,
        Bold
    }

    enum temp
    {
        Iced = 1,
        Hot
    }

    enum mix
    {
        none = 0,
        WholeMilk,
        HoneyAlmondMilk,
        VanillaSweetCream,
        SaltedCaramelSweetCream

    }

    enum sweetener              //  Enums are outside the struct or class
    {
        none = 0,
        Sugar,
        CaneSugar,
        Splenda,
        Honey
       
    }
    enum size
    {
        Small=1,
        Medium,
        Large,
        Ooof
    }
    


    

    internal class Coffee : Beverages
    {


        //checkbox toppings\/
        // none, chocolate, caramel, whipped cream, nuts, graham

        
   
        
        //public string Description { get; set; }
        public int order { get; set; }
        public string Name {  get; set; }
        public roast Roast { get; set; }
        public temp Temp { get; set; }
        public mix Mix { get; set; }
        public sweetener Sweet {  get; set; }
        
        public size Size { get; set; }
        




    }

}

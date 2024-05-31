using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ChallengeLabs4
{
    internal class ElectricBill
    {
        //charge by usage
        // unit
        // 0-199    @1.2/u
        // 200-399  @1.5/u
        // 400-599  @1.8/u  +surcharge %15
        // 600      @2/u    +surcharge %15
        //
        

        public static string ElecBillGen(int custID, string custName, int units)
        {
            int charge = 0;
            if (units > 399)
                charge = units > 599 ?  3 : 2;
            else if (units>199)
                charge = 1;

            switch (charge)
            {
                case 0:
                    return $"Customer ID#: {custID}\nName: {custName}\nUnits consumed:\t\t{units}\nTotal charges @ {1.2:C}:  {units * 1.2:C}\nNet Payment:\t\t{BillCalc(1.2, units):C}" ;  
                case 1:
                    return $"Customer ID#: {custID}\nName: {custName}\nUnits consumed:\t\t{units}\nTotal charges @ {1.5:C}:  {units * 1.5:C}\nNet Payment:\t\t{BillCalc(1.5, units):C}";
                case 2:
                    return $"Customer ID#: {custID}\nName: {custName}\nUnits consumed:\t\t{units}\nTotal charges @ {1.8:C}:  {units * 1.8:C}\nNet Payment:\t\t{BillCalc(1.8, units, true):C}";
                case 3:
                    return $"Customer ID#: {custID}\nName: {custName}\nUnits consumed:\t\t{units}\nTotal charges @ {2:C}:  {units * 2:C}\nNet Payment:\t\t{BillCalc(2, units, true):C}";
            }
            return "Missed something...";
        }

        private static double BillCalc(double rate, int units, bool surcharge=false)
        {
            double total = surcharge ? (rate*units)*1.15:rate * units;
            
            return total;
        }



    }
}

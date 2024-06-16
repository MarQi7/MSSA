using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegation
{
    delegate void LowBalanceDelegate(double bal); // event handler
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        private double acctBal;

        public event LowBalanceDelegate LowBalance;
        public double AccountBalance
        {
            get { return acctBal; }
            set
            {
                if (value < 200)
                {
                    LowBalance(value);
                }
                else { acctBal = value;}

            }
        }

        
    }
}

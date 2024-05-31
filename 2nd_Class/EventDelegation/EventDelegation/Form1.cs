using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDelegation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            BankAccount account = new BankAccount(); //click creates this instance of bank acct.
            account.LowBalance += Account_LowBalance; //adds the event for the handler LowBalance & creates below...
            account.AccountNumber = int.Parse(AcctBalBox.Text);
            account.AccountBalance = double.Parse(AcctBalBox.Text); //the event must be added before the attribute that is being checked
        }

        private void Account_LowBalance(double bal) //restulting handler
        {
            MessageBox.Show($"The balance of {bal} is insufficient, please enter a minimum of $200");
        }
    }
}

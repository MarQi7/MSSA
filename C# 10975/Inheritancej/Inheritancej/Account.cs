using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritancej
{
    internal class BankAccount
    {
        private int acct_num;
        private string accountName;
        private string path;
        private double overDraft = 10;
        Random random = new Random();
        public int AccountNumber { get{ return acct_num; }
            set
            {
                acct_num = value + 12150000 + random.Next(5,500);
            }
        }
        public string AccountName { get { return accountName; }
            set 
            {
                this.accountName = value;
                path = @"C:\Users\deand\MSSA\texts\" + accountName + ".txt";
                File.Create(path).Close();
            }
        }
        private double balance;
        private double minBalance = 25;  
        public double Balance { get { return this.balance; }
            set
            {
                if (value < 200)
                {
                    value -= 1;
                }
                this.balance = value;
            }
        }
        public double MinBalance { get { return minBalance; } }

        public void Deposit(double amount)
        {
            this.balance += amount;
            File.AppendAllText(path, $"[{DateTime.Now}] +{amount:C} \n\n{AccountName} has a balance of {Balance:C} after a deposit of {amount:C}");
            Console.WriteLine($"Your current balance is: {Balance:C}");
        }
        public void Withdraw(double amount)
        {
            if (balance - amount > minBalance)
            {
                this.balance -= amount;
                File.AppendAllText(path, AccountName);
                Console.WriteLine($"[{DateTime.Now}] -{amount:C} \n\n{amount:C} successfully withdrawn.\nYour current balance is: {Balance:C}");
                Console.WriteLine($"Your current balance is: {Balance:C}");
                
                
            }
            else 
            { 
                this.balance -= amount;
                this.balance -= overDraft;
                Console.WriteLine("Your account was overdrafted. A $10 fee will be applied.");
                File.AppendAllText(path, $"[{DateTime.Now}] -{amount+overDraft:C} \n\n{AccountName} has a balance of {Balance:C} after a withdrawl of {amount:C} + {overDraft:C}");
                Console.WriteLine($"Your current balance is: {Balance:C}");
            }
        }

    }
    class SavingsAccount : BankAccount
    {
        

        private int interest;
        public int InterestRate { get {  return interest; } }   

    }
    class CheckingAccount: BankAccount
    {
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount checking = new CheckingAccount();
            SavingsAccount savings = new SavingsAccount();

            Console.WriteLine("**Bank Account Transactions**");
            Console.Write("\nLets create a new account...\nPlease enter teh account holders name: ");
            string name = Console.ReadLine();   
            //input and return accnt # you have been assigned lxenf
            
            Console.Write($"Please enter the initial deposit amount. (minimum of {25:C}): ");
            double deposit = double.Parse( Console.ReadLine() ); 
            //take initial balance amnt... should i do this in the function of the balance class? thats what i normally do...

            //if less than initial amount... please enter at least minimum balance - use label to return. 
            
            checking.AccountName = name;
            checking.AccountNumber = 0;
            checking.Balance = deposit;

            Console.WriteLine($"Your account information:\n\nAccount#: {checking.AccountNumber}\nName: {checking.AccountName}\nAccount Balance: {checking.Balance:C}");
            transaction:
            Console.WriteLine("\nWhat kind of transaction would you like to make? \n\n[1] Deposit\n[2] Withdraw\n");


            int choice= int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter the amount you wish to deposit: ");
                    double dAmount = double.Parse(Console.ReadLine());
                    checking.Deposit(dAmount);
                    break;
                case 2:
                    Console.Write("Please enter the amount you wish to withdraw: ");
                    double wAmount = double.Parse(Console.ReadLine());
                    checking.Withdraw(wAmount);
                    break;
                default:
                    Console.WriteLine("That was not a valid option.\nPress any key to continue");
                    Console.ReadKey();
                    goto transaction;
            }
            Console.WriteLine("Would you like to make another transaction? [Y]/[N]");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                goto transaction;
            }
            Console.WriteLine("\nPress any key to exit..."); 
            Console.ReadKey();
        }
    }
}

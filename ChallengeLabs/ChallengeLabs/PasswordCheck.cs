using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLabs
{
    internal class PasswordCheck
    {

        private static string _user;
        private static string _password;
        public static string User { get { return _user; } }
        public static string Password 
        { get
            {
                return _password;
            }
        }
        private static string acctDate;
        public static string AccountDate {  get { return acctDate; } }
        
        public static void CreateAcct()
        {
            
            Console.Write("\nPlease enter a desired username: ");
            _user = Console.ReadLine();
            Console.Write("\nPlease enter a new password: ");
            _password = Console.ReadLine();
            Console.WriteLine($"\n\n\t\tWelcome {User}.\n\n\t\tYour account has been created and you have been logged out...");
            acctDate = Convert.ToString(DateTime.Today);
        }
        public static void CheckPW() 
        {

            restart:
            Console.Write("\n\nPlease enter your username: ");
            int tries = 2;
            
            string username = Console.ReadLine();
            if (username != User)
            {
                Console.WriteLine("\nYou have entered the wrong username... Please try again.\n");
                goto restart;
            }
            else
            {
                retry:
                Console.Write("\nPlease enter your password: ");
                string password = Console.ReadLine();
                if (password != Password && tries > 0)
                {
                    Console.WriteLine($"\n\nYour password is incorrect... You have {tries} attempts remaining.\n");
                    tries--;
                    goto retry;
                }
                else if (password == Password)
                {
                    Console.WriteLine("\n\nYou have successfully logged into your account.");
                    Console.WriteLine($"\n\n\t\t{User}\n\n\t\t[{AccountDate}]");
                    Console.ReadKey();  
                    Console.WriteLine("Press any key to continue...");
                }
                else 
                {
                    Console.WriteLine("You have entered the incorrect password too many timnes...\n\nYour account has been locked.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    
                }
            }
            
            
            
        }
    }
}

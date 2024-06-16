using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            username:
            Console.Write("Enter your username: ");
            var username = Console.ReadLine();
            try
            {
                if (username.ContainsNumbers())
                {
                    throw new UsernameInputException();
                }
                                
            } 
            catch(UsernameInputException e)
            {
                Console.WriteLine(e.Message+"\nTry agian...");
                goto username;
            }
            
            cardnum:
            Console.Write("Please enter the card number: ");
            var cardnum = Console.ReadLine();
            try
            {
                if (cardnum != "2201100032013902") 
                {
                    throw new CardNotFoundException();
                }
            }
            catch(CardNotFoundException e)
            {
                Console.WriteLine(e.Message);
                goto cardnum;
            }
            finally
            {
                Console.WriteLine("Follow up message"); // always runs this...
            }
        }
    }
}

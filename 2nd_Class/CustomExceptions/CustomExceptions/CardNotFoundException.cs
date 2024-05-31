using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    internal class CardNotFoundException:Exception
    {
        string message = ($"Card not found.\nPlease try again...");

        public override string Message
        {
            get { return message; }
        }
    }
    internal class UsernameInputException : Exception
    {
        string message = ("Please enter a username without digits.");
        public override string Message
        {
            get { return message; }
        }
            
    }
}

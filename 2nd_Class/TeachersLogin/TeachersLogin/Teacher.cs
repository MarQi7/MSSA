using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachersLogin
{
    public class Teacher
    {
        private string userN = "Admin";
        private string passW = "Password";
        public string UserName {  get { return userN; } }
        public string PassWord { get {  return passW; } }
    }
}

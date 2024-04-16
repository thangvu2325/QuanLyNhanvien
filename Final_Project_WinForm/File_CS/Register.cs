using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm.File_CS
{
    public class Register
    {
        public string username;
        public string password;
        public string rePassword;
        public Register(string username, string password, string rePassword)
        {
            this.username = username;
            this.password = password;
            this.rePassword = rePassword;  
        }
        public bool isCheckDuplicatePassword()
        {
            return this.password == this.rePassword;
        }
    }
}

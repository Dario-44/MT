using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTracker
{
    class Account
    {
        public string Password { get; set; }
        public string Email { get; set; }

        public Account(string password, string email)
        {
            Password = password;
            Email = email;
        }
    }
}

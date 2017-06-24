using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Accounts
    {
        public string username;
        public string password;
        public string recoveryQ;
        public int balance;

        //Create a new Account function
        public Accounts(string username, string pass, string recoveryq, int balance)
        {
            this.username = username;
            this.password = pass;
            this.recoveryQ = recoveryq;
            this.balance = balance;
        }

    }
}

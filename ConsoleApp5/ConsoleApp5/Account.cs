using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Account
    {
        public Account() { 
        AccountId = 0;
        AccountBalance = 0.0;
        }
        public Account(int accountId, Double accountBalance)
        {
            AccountId = accountId;
            AccountBalance = accountBalance;
        }
        public int AccountId { get; set; }
        public Double AccountBalance { get; set; }
    }
}

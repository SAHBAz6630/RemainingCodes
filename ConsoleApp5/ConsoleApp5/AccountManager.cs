using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class AccountManager
    {
        public static object LockObject { get; } = new object();
        public Account FromAccount { get; set; }
        public Account ToAccount { get; set; }
        public Double AmountToTransfer { get; set; }
        public void Transfer() {

            lock (LockObject)
            {
                if (FromAccount.AccountBalance >= AmountToTransfer)
                {
                    FromAccount.AccountBalance -= AmountToTransfer;
                    ToAccount.AccountBalance += AmountToTransfer;
                    Console.WriteLine($"Transferred {AmountToTransfer} from Account {FromAccount.AccountId} to Account {ToAccount.AccountId}");
  
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
        }

        public AccountManager(Account fromAccount, Account toAccount, Double amountToTransfer)
        {
            FromAccount = fromAccount;
            ToAccount = toAccount;
            AmountToTransfer = amountToTransfer;
        }
      

    }
}

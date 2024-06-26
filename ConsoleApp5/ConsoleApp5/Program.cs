using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account accA = new Account(1,500000);
            Account accB = new Account(2, 300000);

            AccountManager mg = new AccountManager(accA, accB, 100000);

            AccountManager mg2 = new AccountManager(accB, accA, 30000);
            
            Thread transferThread = new Thread(new ThreadStart(mg.Transfer));
            transferThread.Start();

            Thread transferThread2 = new Thread(new ThreadStart(mg2.Transfer));
            transferThread2.Start();


            transferThread.Join();
            transferThread2.Join();

           
            Console.WriteLine($"Final Balance of Account {accA.AccountId}: {accA.AccountBalance}");
            Console.WriteLine($"Final Balance of Account {accB.AccountId}: {accB.AccountBalance}");

            Console.ReadLine(); 
        }
    }
}

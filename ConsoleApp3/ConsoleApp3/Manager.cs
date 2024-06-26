using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Manager : Employee
    {
        public Manager() : base() { }   
        public Manager(string name, string title, string gender, int age, int baseSalary) : base(name,title,gender,age,baseSalary)
        {
           
        }

       

        public new double Calbonus() {
             double bonus =BaseSalary/10;
            return bonus;
        }
        public new void  Details()
        {
            base.Details();
            Console.WriteLine($"{Calbonus()}");
           
        }
    }
}

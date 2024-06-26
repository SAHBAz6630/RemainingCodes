using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee
    {
       
      public string Name { get; set; }
      public string Title { get; set; }
      public string Gender { get; set; }
      public int Age { get; set; }
      public int BaseSalary { get; set; }

     public virtual double Calbonus() {
            return  0;
        }
        public Employee()
        {
            Name = "provide employee name";
            Title = "provide title";
            Gender = "provide gender";
            Age = 0;
            BaseSalary = 0;
           
        }
        public Employee(string name, string title, string gender, int age, int baseSalary)
        {
            Name = name;
            Title = title;
            Gender = gender;
            Age = age;
            BaseSalary = baseSalary;

        }

        public virtual void Details() {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Title}");
            Console.WriteLine($"{Gender}");
            Console.WriteLine($"{Age}");
            Console.WriteLine($"{BaseSalary}");
           
        }
    }
}

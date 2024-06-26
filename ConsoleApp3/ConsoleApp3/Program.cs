using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("sahbaz", "employee", "male", 24, 300000);
            emp.Details();
            Console.WriteLine("*****************************************");
        
          Manager mg = new Manager("sahbaz","manager","male",24,100000);
            mg.Details();
            Console.WriteLine("*****************************************");

            DeliveryPartner dp = new DeliveryPartner("sahbaz", "delivery", "male", 24, 200000);
            dp.Details();
            Console.WriteLine("*****************************************");

            Employee emp2 = new Manager("rakesh", "manager", "male", 24, 500000);
            emp2.Details();




            /*  Car[] cr = new Car[10];
              foreach(Car c in cr) {
                  c.Start();
                  c.Stop();
                  c.Drive();
              }
              Bicycle[] bc = new Bicycle[10];
              foreach (Bicycle b in bc)
              {
                  b.Start();
                  b.Stop();
                  b.Drive();
              } */
            IDrivable[] vehicles = new IDrivable[]
         {
            new Car(),
            new Bicycle()
         };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("*****************************************");
                vehicle.Stop();
                vehicle.Start();
                vehicle.Drive();
                Console.WriteLine("*****************************************");
            }

            Console.ReadLine();
        }
    }
}

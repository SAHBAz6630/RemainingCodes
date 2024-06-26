using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Car : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Drive the Car");
        }

        public void Start()
        {
            Console.WriteLine("Start the Car");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the Car");
        }
    }
}

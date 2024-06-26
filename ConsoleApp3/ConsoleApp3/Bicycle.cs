using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Bicycle : IDrivable
    {
        public void Drive()
        {
            Console.WriteLine("Drive the Bicycle");
        }

        public void Start()
        {
            Console.WriteLine("Start the Bicycle");
        }

        public void Stop()
        {
            Console.WriteLine("Stop the Bicycle");
        }
    }
}

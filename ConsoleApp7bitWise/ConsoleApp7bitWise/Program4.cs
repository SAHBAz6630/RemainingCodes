using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7bitWise
{
    public class SwapNumbers
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }

        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}

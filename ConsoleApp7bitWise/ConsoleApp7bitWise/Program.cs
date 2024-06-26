/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7bitWise
{

    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            CountSetBits(n);
        }

        static void CountSetBits(int n)
        {

            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                int num = i;
                while (num != 0)
                {
                    count += num & 1;
                    num >>= 1;
                }
                Console.WriteLine($"{i}:Number of set bit count : {count}");
            }

            Console.ReadLine();
        }

    }
}
*/
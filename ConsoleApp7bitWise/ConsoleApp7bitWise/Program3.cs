using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7bitWise
{
    public class FindUniqueElements
    {
        public static void FindTwoUniqueNumbers(int[] nums)
        {
            // Step 1: XOR all the elements in the array
            int xorAll = 0;
            foreach (int num in nums)
            {
                xorAll ^= num;
            }

            // Step 2: Find a set bit in xorAll (rightmost set bit)
            int rightmostSetBit = xorAll & -xorAll;

            // Step 3: Divide elements into two groups and XOR them
            int unique1 = 0, unique2 = 0;
            foreach (int num in nums)
            {
                if ((num & rightmostSetBit) == 0)
                {
                    unique1 ^= num;
                }
                else
                {
                    unique2 ^= num;
                }
            }

            // The two unique numbers
            Console.WriteLine("The two unique numbers are: " + unique1 + " and " + unique2);
        }

        public static void Main()
        {
            int[] nums = { 1, 2, 4, 3, 3, 2, 5, 1 };
            FindTwoUniqueNumbers(nums);
        }
    }
}

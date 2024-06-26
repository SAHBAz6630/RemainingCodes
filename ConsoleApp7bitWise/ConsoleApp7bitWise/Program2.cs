using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7bitWise
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a binary string: ");
            string binaryString = Console.ReadLine();

            int decimalValue = BinaryToDecimal(binaryString);
            Console.WriteLine($"Binary {binaryString} is equal to decimal {decimalValue}");
        }

        static int BinaryToDecimal(string binaryString)
        {
            int decimalValue = 0;
            int power = 0;
            

            for (int i = binaryString.Length - 1; i >= 0; i--)
            {

                if (binaryString[i] == '1')
                {

                    decimalValue += (int)Math.Pow(2, power);
                }
                else if (binaryString[i] != '0')
                {
                    Console.WriteLine($"Invalid binary string: {binaryString}");
                    return 0;
                }


                power++;
                
            }
            return decimalValue;




            
        }
        
        
    }
    
}

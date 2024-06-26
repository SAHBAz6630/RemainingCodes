using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* int[] arr = { 100, 200, 300, 400, 500 };
             Stack<int> intArray = new Stack<int>(arr);
             Console.WriteLine(intArray.Count);

             foreach(int item in intArray) {
                 Console.WriteLine(item);           
             }

             intArray.Push(600);
             intArray.Push(700);
             intArray.Push(800); *//*

            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Peek()); // Peek at the top element
                stack.Pop();
                if (stack.IsEmpty()) {
                    Console.WriteLine("stack is empty now");
                }// Pop the top element
            }

            int[] arr = new int[5];

            Stack<int> intarr = new Stack<int>(arr);
           
           
            
            foreach (int item in intarr) {
                Console.WriteLine(item);
            }

           // int[] arr2 = new int[6];


            Console.ReadLine();

        }

    }
}
*/

            /*using System;

            class Program
            {
                static void Main()
                {
                    CustomStack<int> customStack = new CustomStack<int>(5);

                    // Pushing elements onto the stack
                    customStack.Push(1);
                    customStack.Push(2);
                    customStack.Push(3);
                    customStack.Push(4);
                    customStack.Push(5);



                    foreach (int item in customStack.GetElements())
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("after pushing 5 element*************************");

                    // Printing the count of elements in the custom stack
                    Console.WriteLine("Total Count: " + customStack.TotalCount());

                    customStack.Push(6);



                    // Printing elements of the custom stack
                    foreach (int item in customStack.GetElements())
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("after pushing 6 element*************************");

                    // Printing the count of elements in the custom stack
                    Console.WriteLine("Total Count: " + customStack.TotalCount());
            */




            BaseClass baseClass = new BaseClass();
            DerivedClass derivedClass = new DerivedClass();
            OtherClass otherClass = new OtherClass();

            baseClass.DisplayFields();
            derivedClass.DisplayDerivedFields();
            otherClass.DisplayOtherFields(baseClass);

            Console.ReadLine();
        }
    }
}

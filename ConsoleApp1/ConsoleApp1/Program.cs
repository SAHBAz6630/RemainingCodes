using System;
using System.CodeDom;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int i;

        static void Main(string[] args)
        {
            /* Console.WriteLine("***********Enter your details***************");

             Console.WriteLine("enter your first name");
             string Fname = Console.ReadLine();

             Console.WriteLine("enter your last name");
             string Lname = Console.ReadLine();

             Console.WriteLine("enter your age");
             string age = Console.ReadLine();
             int age1 = Convert.ToInt32(age);

             Console.WriteLine("enter your address2");
             string address = Console.ReadLine();

             Console.WriteLine("enter your address");
             string address2 = Console.ReadLine();

             Console.WriteLine("enter your contact");
             string contact = Console.ReadLine();
             long contact1 = Convert.ToInt64(contact);

             Console.WriteLine("enter your city");
             string city = Console.ReadLine();


             Console.WriteLine("enter your state");
             string state = Console.ReadLine();

             Console.WriteLine("enter your emailId");
             string email = Console.ReadLine();

             Console.WriteLine("enter your gender");
             string gender = Console.ReadLine();




             Console.WriteLine("******************** Student details entered by you***********************");

             Console.WriteLine("FName :" + Fname + "\n" +
                 "LName :" + Lname + "\n" +
                 "age :" + age1 + "\n" +
                 "address :" + address + "\n" +
                  "address2 :" + address2 + "\n" +
                 "contact :" + contact1 + "\n" +
                "city :" + city + "\n" +
                 "state :" + state + "\n" +
                "email :" + email + "\n" +
                "gender :" + gender + "\n" 
                 );
             Console.ReadLine();


             // "Address :" + address1 + "\n" + "contact :" + contact1 +
             // "Name :" + name + "\n" + "age :" + age +
             // "Name :" + name + "\n" + "age :" + age +);
             // "Name :" + name + "\n" + "age :" + age1
             //name,age1,address,contact1,collegeName,fees1,fatherName,motherName,department,hobby

             */

            //TASK2

            /*       string addmore = "";
                //   int quantity;
                   int val;
                   int coffee = 0;
                   int GS = 0;
                   int FF = 0;
                   int NO = 0;
                   int PZ = 0;
                   int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, sum5 = 0, RawBill = 0;
                   double  CGST = 0, SGST = 0, TOTAL = 0;
                   do
                   {
                       Console.WriteLine("**********Todays MENU*****************");
                       Console.WriteLine("1. Coffee   : 40 RS");
                       Console.WriteLine("2. Grilled Sandwhich : 80 RS");
                       Console.WriteLine("3. French Fries : 60 RS");
                       Console.WriteLine("4. Noodles  : 50 RS");
                       Console.WriteLine("5. Pizza : 120 RS");
                       Console.WriteLine("************************************************************");

                       Console.WriteLine("select any item");
                       val = Convert.ToInt32(Console.ReadLine());




                   switch (val)
                   {
                       case 1:
                           Console.WriteLine("You have selected : Coffee");
                               Console.WriteLine("select the quantity");
                               coffee = Convert.ToInt32(Console.ReadLine());
                               sum1 = coffee * 40;
                           break;

                       case 2:
                           Console.WriteLine("You have selected : Grilled Sandwhich");
                               Console.WriteLine("select the quantity");
                               GS = Convert.ToInt32(Console.ReadLine());
                               sum2 = coffee * 80;
                               //   Console.WriteLine("total quantity of Grilled Sandwhich  " + quantity);
                               break;

                       case 3:
                           Console.WriteLine("You have selected : French Fries");
                               Console.WriteLine("select the quantity");
                               FF = Convert.ToInt32(Console.ReadLine());
                               sum3 = coffee * 60;

                               //Console.WriteLine("total quantity of French Fries  " + quantity);
                               break;

                       case 4:
                           Console.WriteLine("You have selected : Noodles");
                               Console.WriteLine("select the quantity");
                               NO = Convert.ToInt32(Console.ReadLine());
                               sum4 = coffee * 50;
                               // Console.WriteLine("total quantity of Noodles  " + quantity);
                               break;
                       case 5:
                           Console.WriteLine("You have selected : Pizza");
                               Console.WriteLine("select the quantity");
                               PZ = Convert.ToInt32(Console.ReadLine());
                               sum5 = coffee * 120;

                               // Console.WriteLine("total quantity of Pizza  " + quantity);
                               break;
                   }

                       Console.WriteLine("You want to add more item (Y,N)");
                       addmore = Console.ReadLine();



                   } while (addmore == "Y");
                   RawBill = (sum1 + sum2 + sum3 + sum4 + sum5) ;
                   CGST = (RawBill * 5) / 100;
                   SGST = (RawBill * 5) / 100;
                   TOTAL = RawBill + CGST + SGST;

                   Console.WriteLine("Coffee :" + coffee + "\n" +
                       "Grilled Sandwhich :" + GS + "\n" +
                       "French Fries :" + FF + "\n" +
                       "Noodles :" + NO + "\n" +
                       "Pizza :" + PZ + "\n" 
                        );

                   Console.WriteLine("Total bill :" + RawBill + "\n" +
                       "CGST :" + CGST + "\n" +
                       "SGST :" + SGST + "\n" +
                       "TOTAL AMOUNT TO PAY :" + TOTAL + "\n" );

                   Console.ReadLine();  */


            int[] arr = new int[] {1,2,3,4,5,6,7,8,9,10 };

            void slicearr(int Startindex, int Endindex) {  //slice method

                for (int i = Startindex; i <= Endindex; i++) {
                    Console.WriteLine("sliced array is : " + arr[i]);
                }
                
            }

           

            void reverseArr(int[] arr1) {
                for (int i = arr1.Length-1; i >= 0; i--)
                {
                    Console.WriteLine("reverse array is : " + arr1[i]);
                }
                
            }

            void updateElement(int[] arr2, int index, int value) {
                for (int i = 0; i < arr2.Length - 1; i++)
                {
                    if (i == index)
                    {
                        arr[i] = value;                      
                    }
                    Console.WriteLine(arr2[i]);
                }
                
            }

           reverseArr(arr);
             slicearr(2, 8);
            updateElement(arr, 2, 100);


            Console.ReadLine();

        }
    }
}

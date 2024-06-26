using System;

class ArrayOperations
{
    public static void Main(string[] args)
    {
        int coffeecount = 0;
        int sandwitchcount = 0;
        int frenchfriescount = 0;
        int noodlescount = 0;
        int pizzacount = 0;
        string addItem = " ";

        int cfbill = 0;
        int swbill = 0;
        int ffbill = 0;
        int Ndbill = 0;
        int pzbill = 0;

        double Bill = 0;
        double CGST = 0;
        double SGST = 0;
        double TOTAL_BILL = 0;
        int[] Items = { 1, 2, 3, 4, 5 };

        int[] PriceOfItem = { 40, 80, 60, 50, 120 };

        int[] ItemPurchased = new int[Items.Length];
        int[] ItemQuantityPurchased = new int[Items.Length];


        void ShowMenu()
        {
            Console.WriteLine("***TODAY'S MENU****");
            Console.WriteLine("1.coffee : 40rs");
            Console.WriteLine("2.Grilled Sandwitch: 80rs");
            Console.WriteLine("3.French Fries: 60");
            Console.WriteLine("4.Noodles: 50");
            Console.WriteLine("5.Pizza : 60");
            // Console.WriteLine("enter the number you want to select");
            // int item = Convert.ToInt32(Console.ReadLine());

        }
        void PurchaseItemQuantity()

        {
            // Console.WriteLine(" enter the item number to purchase");
            // int item = Convert.ToInt32(Console.ReadLine());
            do
            {
                ShowMenu();
                Console.WriteLine(" enter the item number to purchase");
                int item = Convert.ToInt32(Console.ReadLine());


                switch (item)
                {
                    case 1:
                        Console.WriteLine("you selected coffee");
                        Console.WriteLine("enter the quantity");
                        coffeecount = Convert.ToInt32(Console.ReadLine());
                        cfbill = coffeecount * 40;
                        break;

                    case 2:
                        Console.WriteLine("you selected grilled sandwitch");
                        Console.WriteLine("enter the quantity");
                        sandwitchcount = Convert.ToInt32(Console.ReadLine());
                        swbill = sandwitchcount * 80;
                        break;
                    case 3:
                        Console.WriteLine("you selected french fries");
                        Console.WriteLine("enter the quantity");
                        frenchfriescount = Convert.ToInt32(Console.ReadLine());
                        ffbill = frenchfriescount * 60;
                        break;
                    case 4:
                        Console.WriteLine("you selected Noodles");
                        Console.WriteLine("enter the quantity");
                        noodlescount = Convert.ToInt32(Console.ReadLine());
                        Ndbill = noodlescount * 50;

                        break;

                    case 5:
                        Console.WriteLine("you selected pizza");
                        Console.WriteLine("enter the quantity");
                        pizzacount = Convert.ToInt32(Console.ReadLine());
                        pzbill = pizzacount * 120;
                        break;

                    default:
                        Console.WriteLine(" please select only 1 to 5 items only");
                        break;
                }
                Console.WriteLine("you want add more items(Y/N)");
                addItem = Console.ReadLine();
            } while (addItem == "y");


        }
        void CalculateBill()
        {
            cfbill = coffeecount * PriceOfItem[0];
            swbill = sandwitchcount * PriceOfItem[1];
            ffbill = frenchfriescount * PriceOfItem[2];
            Ndbill = noodlescount * PriceOfItem[3];
            pzbill = pizzacount * PriceOfItem[4];
            Bill = (cfbill + swbill + ffbill + Ndbill + pzbill);
            CGST = (Bill * 5) / 100;
            SGST = (Bill * 18) / 100;
            TOTAL_BILL = Bill + CGST + SGST;
            Console.WriteLine("coffee:" + coffeecount + "\n" +
            "grilled sandwitch :" + sandwitchcount + "\n" +
            "French Fries:" + frenchfriescount + "\n" +
              "Noodles:" + noodlescount + "\n" +
              "Pizza:" + pizzacount + "\n");
            Console.WriteLine("Total_bill:" + TOTAL_BILL + "\n" +
                               "CGST:" + CGST + "\n" +
                                "SGST:" + SGST + "\n");

        }

        PurchaseItemQuantity();
        CalculateBill();


    }
} 
}
}
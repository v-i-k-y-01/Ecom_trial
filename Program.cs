using System;
using System.Reflection.Metadata.Ecma335;
using trial;
class Alpha
{

    public static void Main(String[] args)
    {

        //objects
        Ecom ecom = new Ecom();
        Console.WriteLine("Welcome to UrbanHive !");

        Console.WriteLine();
        Console.WriteLine();

       
        Console.WriteLine(@"1.Home
2.Offer Zone
3.Clearance Sale
4.Hive Basics
5.Your Cart
6.Your Bill ");
        Console.WriteLine();
         Console.WriteLine("Select Your Preferd Choices");
        Console.WriteLine() ;

        
        
        
        while (true)
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected Home.");
                    ecom.Home();
                    break;
                case 2:
                    Console.WriteLine("You selected Offer Zone.");
                   ecom.offerZone();
                    break;
                case 3:
                    Console.WriteLine("You selected Clearance Sale.");
              ecom.Clearance();
                    break;
                case 4:
                    Console.WriteLine("You selected Hive Basics.");
                    ecom.Hive();
                    break;
                case 5:
                    Console.WriteLine("You selected Your Cart.");
                    ecom.Cart();
                    break;
                case 6:
                    Console.WriteLine("You selected Your Bill.");
                    // Add logic for Your Bill
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 6.");
                    break;

            }
        }
    }
}

       
   

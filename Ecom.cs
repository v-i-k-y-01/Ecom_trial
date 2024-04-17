using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace trial
{
    public class Ecom
    {
        Dictionary<int, string> homeMap = new Dictionary<int, string>();
        Dictionary<int, string> OfferMap = new Dictionary<int, string>();
        Dictionary<int, string> clearMap = new Dictionary<int, string>();
        Dictionary<int, string> hiveMap = new Dictionary<int, string>();
        List<string> cart=new List<string>();
        List<string> carts = new List<string>();


        public void offerZone()
        {
            OfferMap.Add(1, "Samsung s23");
            OfferMap.Add(2, "Wobble machine");
            OfferMap.Add(3, "rare rabbit");
            OfferMap.Add(4, "Smart LEOffer");
            foreach (KeyValuePair<int, string> kvp in OfferMap)
            {
                Console.WriteLine(kvp.Key + "." + kvp.Value);
            }
            Console.WriteLine("Add items to the cart:");
            int item = int.Parse(Console.ReadLine());
            cart.Add(OfferMap[item]);
        }
        public void Clearance()
        
        {
            clearMap.Add(5, "Coffee Maker");
            clearMap.Add(6, "Air Purifier");
            clearMap.Add(7, "Bluetooth Speaker");
            foreach (KeyValuePair<int, string> kvp in clearMap)
            {
                Console.WriteLine(kvp.Key + "." + kvp.Value);
            }
            Console.WriteLine("Add items to the cart:");
            int item = int.Parse(Console.ReadLine());
            cart.Add(clearMap[item]);
        }
       
        public void Hive()
        {

            hiveMap.Add(8, "Robot Vacuum Cleaner");
            hiveMap.Add(9, "Electric Kettle");
            hiveMap.Add(10, "Wireless Headphones");
            foreach (KeyValuePair<int, string> kvp in hiveMap)
            {
                Console.WriteLine(kvp.Key + "." + kvp.Value);
            }
            Console.WriteLine("Add items to the cart:");
            int item = int.Parse(Console.ReadLine());
            cart.Add(hiveMap[item]);
        }

        public void Cart()
        {
            foreach(var i in cart)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Do you wish to confirm this cart for bill or want to modify it ?");
            String ans= Console.ReadLine();
            if(ans!="confirm")
            {
                Console.WriteLine("Do you want to add or remove?");
                string rep=Console.ReadLine();
                if (rep=="remove"||rep=="REMOVE")
                {
                    Console.WriteLine("Give the key of the item to be removed ?");
                    string  k=Console.ReadLine();
                    if (cart.Contains(k)) 
                    {
                        cart.Remove(k);
                      
                    }
                    
                }
                else if(rep=="add"||rep=="ADD")
                {
                    Home();
                }
            }
        }

        
        public void Home()
        {
            //offerZone();
            //Clearance();
            //Hive();
           
            homeMap.Add(11, "Digital Photo Frame");
            homeMap.Add(12, "Fitness Tracker");

            
            foreach (KeyValuePair<int, string> kvp in homeMap)
            {
                Console.WriteLine(kvp.Key + "." + kvp.Value);
            }
        }
    }
}

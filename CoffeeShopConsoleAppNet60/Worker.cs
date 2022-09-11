using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.MockData;
using CoffeeShopConsoleAppNet60.Service;

namespace CoffeeShopConsoleAppNet60
{
    public class Worker
    {
        public void Start()
        {
            Console.WriteLine("Coffee list from CoffeeShop");
            foreach (var item in Data.CoffeList())
            {
                Console.WriteLine();
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Coffe list with only Milk");
            foreach (var item in Data.CoffeListMilk())
            {
                Console.WriteLine();
                Console.WriteLine(item.ToString());
            }



        }
    }
}

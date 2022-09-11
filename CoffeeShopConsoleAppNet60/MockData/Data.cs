using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.Service;


namespace CoffeeShopConsoleAppNet60.MockData
{
    public class Data
    {

        public static List<Coffee> CoffeList()
        {
            List<Coffee> coffeList = new List<Coffee>()
            {
                new BlackCoffee(2),
                new Latte(2),
                new Cortado(4),
                new FlatWhite(5),
            };
            return coffeList;
        }
        public static List<Coffee> CoffeListMilk()
        {
            List<Coffee> coffeList = new List<Coffee>()
            {
                new Latte(0, 0),
                new Cortado(0, 0),
                new FlatWhite(0, 0)
            };
            return coffeList;
        }
    }
}

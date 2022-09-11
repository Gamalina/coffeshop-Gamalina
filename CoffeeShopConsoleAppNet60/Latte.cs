using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.Service;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte() : base()
        {

        }

        public Latte(int discount) : base(discount)
        {

        }

        public Latte(int discount, int milk) : base(discount, milk)
        {
            milk = MlMilk();
        }

        public override int Price()
        {
            return 40 - base.Discount;
        }


        public override string CoffeeType()
        {
            return "Latte";
        }

        public override string Strength()
        {
            return "Weak";
        }

        public override int MlMilk()
        {
            return 200;
        }
    }
}

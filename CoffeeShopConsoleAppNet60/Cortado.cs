using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.Service;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado() : base()
        {

        }

        public Cortado(int discount) : base(discount)
        {

        }

        public Cortado(int discount, int milk) : base(discount, milk)
        {

        }

        public override int Price()
        {
            return 25 - base.Discount;
        }


        public override string CoffeeType()
        {
            return "Cortado";
        }

        public override string Strength()
        {
            return "Medium";
        }

        public override int MlMilk()
        {
            return 40;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlatWhite : Coffee
    {

        public FlatWhite() : base()
        {

        }

        public FlatWhite(int discount) : base (discount)
        {

        }

        public FlatWhite(int discount, int milk) : base(discount, milk)
        {

        }

        public override int Price()
        {
            return 40 - base.Discount;
        }

        public override string CoffeeType()
        {
            return "Flat White";
        }

        public override int MlMilk()
        {
            return 30;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}

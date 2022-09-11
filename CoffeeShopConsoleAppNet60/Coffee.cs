using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleAppNet60.Service;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee : IMilk
    {

        private int _discount;
        private int _milk;

        protected int Discount { get; private set; }

        protected Coffee()
        {
            
        }
        protected Coffee(int discount)
        {
            if (discount > 5)
            {
                throw new ArgumentException("Discount too high.");
            }
            _discount = discount;
        }

        protected Coffee(int discount, int milk)
        {
            _discount = discount;
            _milk = MlMilk();
        }

        public virtual int Price()
        {
            return 20 - Discount;
        }

        public abstract string Strength();
        public abstract string CoffeeType();

        public abstract int MlMilk();

        public override string ToString()
        {
            return $"Item: \t\t{this.CoffeeType()} \nStrength: \t{this.Strength()} \nPrice: \t\t{this.Price()},- \nMilk: \t\t{this.MlMilk()}ml";
        }

    }
}

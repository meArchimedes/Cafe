using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeDeVenezia.Drinks___Abs_Factory;

namespace CafeDeVenezia.Drinks
{
    internal class HotCoffee: Coffee
    {
        public HotCoffee()
        {
            Order.details += "\nHot Coffee\n";
        }

        public override int GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
}

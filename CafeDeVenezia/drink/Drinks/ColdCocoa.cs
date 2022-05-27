using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeDeVenezia.Drinks___Abs_Factory;

namespace CafeDeVenezia.Drinks
{
    internal class ColdCocoa: Cocoa
    {
        public ColdCocoa()
        {
            Order.details += "\nCold Cocoa\n";
        }

        public override int GetPrice()
        {
            return base.GetPrice()+1;
        }
    }
}

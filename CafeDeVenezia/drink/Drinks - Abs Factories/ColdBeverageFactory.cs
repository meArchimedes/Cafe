using CafeDeVenezia.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Drinks___Abs_Factory
{
    internal class ColdBeverageFactory: BeverageFactory
    {
        public override Cocoa CreateCocoa()
        {
            ColdCocoa cc = new();
            return cc;
        }
        public override Coffee CreateCoffee()
        {
            ColdCoffee cc = new();
            return cc;
        }
        public override Tea CreateTea()
        {
            ColdTea ct = new();
            return ct;
        }

        public override int GetPrice()
        {
            return 0;
        }

    }
}

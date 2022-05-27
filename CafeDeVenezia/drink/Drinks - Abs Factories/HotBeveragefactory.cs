using CafeDeVenezia.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Drinks___Abs_Factory
{
    internal class HotBeveragefactory: BeverageFactory
    {
        public override Cocoa CreateCocoa()
        {
            HotCocoa hc = new();
            //Order.price += hc.GetPrice();
            return hc;
        }
        public override Coffee CreateCoffee()
        {
            HotCoffee hc = new();
            //Order.price += hc.GetPrice();
            return hc;
        }
        public override Tea CreateTea()
        {
            HotTea ht = new();
            //Order.price += ht.GetPrice();
            return ht;
        }

        public override int GetPrice()
        {
            return 12;
        }

        
    }
}

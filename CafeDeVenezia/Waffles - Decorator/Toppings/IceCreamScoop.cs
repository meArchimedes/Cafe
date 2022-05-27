using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    internal class IceCreamScoop : ToppingDecorator
    {
        public IceCreamScoop(Waffle w, Shape s):base(w, s)
        {
            Order.details += ("ice cream");
        }
        
        public override int GetPrice()
        {
            return base.GetPrice() + 8;
        }
        public override string Print()
        {
            return base.Print + "Ice cream\n";
        }
    }
}

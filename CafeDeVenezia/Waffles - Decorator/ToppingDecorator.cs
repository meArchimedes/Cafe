using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    internal class ToppingDecorator : WaffleDecorator
    {
        public ToppingDecorator(Waffle w, Shape s) : base(w,s)
        {
        }
        public override string Print()
        {
            return base.Print()+"\nToppings:\n";
        }
        public override int GetPrice()
        {
            return base.GetPrice();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    internal class MilkChocolate : SyrupDecorator
    {

        public MilkChocolate(Waffle w, Shape s) : base(w, s)
        {
            Order.details += "Milk Chocolate\n";
        }
        
        public override int GetPrice()
        {
            return base.GetPrice() + 2;
        }
        public override string Print()
        {
            return base.Print + " + milk choclate\n";
        }
    }
}

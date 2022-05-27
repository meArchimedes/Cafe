using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    abstract class WaffleDecorator: Waffle
    {
        protected Waffle waffle;
        public WaffleDecorator(Waffle w, Shape s): base(s)
        {
            this.waffle = w;
        }
        public override int GetPrice()
        {
            return base.GetPrice();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    internal class Butterscotch : SyrupDecorator
    {
        Waffle w;
        public Butterscotch(Waffle w, Shape s) : base(w,s)
        {
            Order.details += " Butterscotch\n";
        }
       
        public override int GetPrice()
        {
            return base.GetPrice()+2;
        }
        public override string Print()
        {
            return w.Print() + "+ butterscotch\n";
        }
    }
}

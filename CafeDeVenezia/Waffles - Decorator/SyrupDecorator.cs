using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    abstract class SyrupDecorator : WaffleDecorator
    {
        public SyrupDecorator(Waffle w, Shape s) : base(w,s)
        {
        }
        public override string Print()
        {
            return base.Print()+"\nSyrups:\n";
        }
        public override int GetPrice()
        {
            return base.GetPrice();
        }
    }
}

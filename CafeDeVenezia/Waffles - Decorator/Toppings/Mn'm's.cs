using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    internal class Mn_m_s : ToppingDecorator
    {
        public Mn_m_s(Waffle w, Shape s) : base(w, s)
        {
            Order.details += "M&M's\n";
        }
        
        public override int GetPrice()
        {
            return base.GetPrice()+2;
        }
        public override string Print()
        {
            return base.Print + "M & M's\n";
        }
    }
}

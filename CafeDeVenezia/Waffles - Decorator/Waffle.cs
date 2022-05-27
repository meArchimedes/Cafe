using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Waffles___Decorator
{
    internal class Waffle
    {

        public Shape shape;

        
        public Waffle(Shape s)
        {
            Order.details += "Waffle\n";
            SetShape(s);
            Order.price += GetPrice();
        }
        public void SetShape(Shape s) 
        {
            shape = s;
        }
        public virtual int GetPrice()
        {
            return 30;
        }
        public virtual string Print()
        {
            return $"{shape} Waffle\n";
        }
    }
}

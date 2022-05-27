using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Drinks
{
    abstract class Tea: Drink
    {
        
        public virtual int GetPrice()
        {
            return base.GetPrice();
        }
       
    }
}

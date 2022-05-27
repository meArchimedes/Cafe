using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeDeVenezia.Drinks___Abs_Factory;

namespace CafeDeVenezia.Drinks
{
    abstract class Drink: BeverageFactory
    {

        public override int GetPrice()
        {
            return 10;
        }
        public virtual Drink CreateDrink()
        {
            return null;
        }
    }
}

using CafeDeVenezia.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Drinks___Abs_Factory
{
    abstract class BeverageFactory
    {
        public virtual Coffee CreateCoffee() { return null; }
        public virtual Tea CreateTea() { return null; }
        public virtual Cocoa CreateCocoa() { return null; }
        public abstract int GetPrice();
    }
}

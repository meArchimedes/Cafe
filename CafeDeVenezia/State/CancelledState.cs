using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class CancelledState : State
    {
        public CancelledState(Order o) : base(o)
        {
            Console.WriteLine("Order CANCELLED due payment failure!");
            Order.price = 0;
        }
        public override void AdvanceState()
        {
            
        }
        public override void CurrentState()
        {
            Console.WriteLine("Cancelled"); 
        }
    }
}

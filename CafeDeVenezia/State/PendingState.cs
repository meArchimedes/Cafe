using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class PendingState : State
    {
        public PendingState(Order o) : base(o)
        {
                
        }
        public override void AdvanceState()
        {
            order.state = new InKitchenState(order);
                
        }
        public override void CurrentState()
        {
            Console.WriteLine("Order is pending!"); 
        }
    }
}

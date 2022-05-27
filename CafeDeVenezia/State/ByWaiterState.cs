using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class ByWaiterState : State
    {
        public ByWaiterState(Order o) : base(o)
        {
            if (o.Items.Count() > 10)
            {
                o.state = new CancelledState(o);
            }
        }
        public override void AdvanceState()
        {
            order.state = new PendingState(order);
        }
        public override void CurrentState()
        {
            Console.WriteLine("Your order is by the waiter."); 
        }
        
    }
}

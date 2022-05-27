using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class InKitchenState : State
    {
        public InKitchenState(Order o) : base(o)
        {
        }
        public override void AdvanceState()
        {
            this.order.state = new InProcessState(order);
        }
        public override void CurrentState()
        {
            Console.WriteLine("Order is in the kitchen!"); 
        }
    }
}

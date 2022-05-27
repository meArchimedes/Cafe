using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class InProcessState : State
    {
        public InProcessState(Order o) : base(o)
        {
        }
        public override void AdvanceState()
        {
            this.order.state = new ReadyState(order);
        }
        public override  void CurrentState()
        {
            Console.WriteLine("Order is in process!"); 
        }
    }
}

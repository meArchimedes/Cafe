using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class ExecutedState : State
    {
        public ExecutedState(Order o) : base(o)
        {
        }

        public override void AdvanceState()
        {
            order.state = new PendingPaymentState(order);
        }
        public override void CurrentState()
        {
            Console.WriteLine("Order Executed!"); 
        }
        //public override void ReverseState()
        //{
        //    this.ChangeState(new ReadyState(order));
        //}
    }
}

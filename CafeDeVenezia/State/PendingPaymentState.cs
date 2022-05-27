using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal class PendingPaymentState : State
    {
        public PendingPaymentState(Order o) : base(o)
        {
            Console.WriteLine($"Enter {Order.price}");
            Admin.Administrator.Pay();
        }
        public override void AdvanceState()
        {
            if (Order.Paid)
            {
                order.state = new ReadyState(order);
            }
            else
            {
                if(!Order.Paid)
                    order.state = new CancelledState(order);
            }
        }
        public override void CurrentState()
        {
        }
    }
}

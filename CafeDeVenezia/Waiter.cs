using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeDeVenezia.Waffles___Decorator;
using CafeDeVenezia.Waffles___Decorator.Shape___Bridge;

namespace CafeDeVenezia
{
    public class Waiter
    {
        public static Admin admin = new Admin();
        List<string[]> OrderItems;

        public Waiter(Order order)
        {
            order.state.AdvanceState();//Send to waiter
            order.state.CurrentState();
            OrderItems = order.Items;
            
            //pending
            order.state.AdvanceState();
            order.state.CurrentState();

            //execute
            SendOrder(order);

            //Ready state
            order.state.AdvanceState();
            order.state.CurrentState();
            //payment

            order.state.AdvanceState();
            order.state.CurrentState();

            admin.Pay();
            Order.w = null;
            Order.price = 0;
        }
        
        private void SendOrder(Order o)
        {
            KitchenReceiver.WorkOffRequests(OrderItems, o);
        }
    }
}

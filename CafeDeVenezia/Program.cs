using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeDeVenezia.Waffles___Decorator;
using CafeDeVenezia.Waffles___Decorator.Shape___Bridge;

namespace CafeDeVenezia;

class program
{
    public static void Main(string[] args)
    {
        //Admin Administrator = new Admin();
        List<Order> orders = new List<Order>();
        Order first = new Order();
        orders.Add(first);
        Waiter waiter = new(first);
        //Administrator.Pay();
    }
}




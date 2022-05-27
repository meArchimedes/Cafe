using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CafeDeVenezia
{
    internal class ReadyState : State
    {
        DateTime time;
        public ReadyState(Order o) : base(o)
        {
            time = DateTime.Now;
            Console.Beep();
            Order.w = null;
            Console.WriteLine($"Your order was ready at {time}!");
            //var list = Json.
        }
        public override void AdvanceState()
        {
            //add to json!
        }
        public override void CurrentState()
        {
            //Console.WriteLine($"Your order was ready at {time}!"); 
        }
    }
}

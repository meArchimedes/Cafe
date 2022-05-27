using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    internal abstract class State
    {
        protected Order order;
        public State(Order o)
        {
            this.order = o;    
        }
        public virtual void AdvanceState()
        {

        }
        public virtual void CurrentState()
        {
        }

    }
}

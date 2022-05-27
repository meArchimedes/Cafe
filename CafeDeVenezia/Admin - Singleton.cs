using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia
{
    public class Admin
    {
        //Singleton DP
        public static Admin Administrator;
        double d;
        //ctors
        public Admin(string s)
        {

        }

        public Admin()
        {
            if (Administrator == null)
            {
                Administrator = new Admin("a");
            }
        }

        //payment receiver
        public bool Pay()
        {
            Console.WriteLine($"Enter {Order.price} $:");
            d = Console.Read();
            if (d < Order.price)
            {
                Order.Paid = false;
                return false;
            }
            Order.Paid = true;
            return true;
        }
    }
}

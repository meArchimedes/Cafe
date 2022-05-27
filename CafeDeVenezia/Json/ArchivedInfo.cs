using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeDeVenezia.Json
{
    public class ArchivedInfo
    {
        public long PhoneNum { get; set; }
        public static List<Order> send { get; set; }
        public static Order reorder = new Order();
        public static Order Retrieve(string date)//retreives order with identical date to clone
        {
            reorder = null;
            if(send == null)
            {
                Console.WriteLine("No previous orders!");
            }
            foreach(var item in send)
            {
                if (item.date.Equals(date))
                {
                    return item;
                }
            }
            return null;
        }
        public ArchivedInfo(List<Order> send, string state, long PhoneNum)
        {
            send = send.Cast<Order>().ToList(); //cast and export
            PhoneNum = PhoneNum;
        }
        public ArchivedInfo()
        {

        }
    }
}

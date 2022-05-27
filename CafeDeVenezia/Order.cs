using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CafeDeVenezia.Json;
using CafeDeVenezia.Waffles___Decorator.Shape___Bridge;

namespace CafeDeVenezia
{
    public class Order : ICloneable
    {
        public static double price;
        public static string details;
        Customer customer;
        public static bool Paid = false;
        internal State state;
        private string[] waffles = new string[9];
        private string[] drinks = new string[3];
        public DateTime date { get; private set; }
        public static Waiter w;
        string OldDate;
        internal List<string[]> Items { get; set; }

        private string[] questionsW =
            {
                "Add a Waffle?(y/n)",
                "Which shape - Square/Round(s/r)",
                "Any syrups?(y/n)",
                "Butterscotch?(y/n)",
                "Milk Chocolate?(y/n)",
                "Any Toppings?(y/n)",
                "Oreo Crumbs?(y/n)",
                "M&M's?(y/n)",
                "An Ice Cream Scoop?(y/n)",
        };

        private string[] questionsD =
        {
                "Add a Drink?(y/n)",
                "Coffee/Tea/Cocoa?(1/2/3)",
                "Hot/Cold?(1/2)"
        };

       //constructor
        public Order()
        {
            Paid = false;
            date = DateTime.Now;
            Items = new List<string[]>();
            PlaceOrder();
            state = new PendingState(this);
            state.CurrentState();
            while (IsBusy(w))
            {
            }
            w = new Waiter(this);

        }

        private bool IsBusy(Waiter w)
        {
            if(w == null)
                return false;
            return true;
        }

        public void PlaceOrder()
        {
            customer = new Customer();
            date = DateTime.Now;
            Console.WriteLine("Bienvenuti a Cafe De Venezia!\nEnter name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Number");
            customer.PhoneNum = Console.ReadLine();
            Console.WriteLine("Do you want a pre-existing order?(y/n)");
            string prevOrder = Console.ReadLine();
            if (prevOrder.Equals("y"))
            {
                //clone from json
                Console.WriteLine("Enter the date of previous order");
                OldDate = Console.ReadLine();
                Clone().ToString();
                Clone();
            }
            else
            {
                int i = 0, j = 0;


                while (waffles[0] != "n")
                {
                    Console.WriteLine(questionsW[i]);

                    waffles[i] = Console.ReadLine();
                    i++;

                    if (i == 9)
                    {

                        i = 0;
                    }

                    if (i == 6 && waffles[5] == "n")
                    {
                        i = 0;
                    }
                    else if (i == 3 && waffles[2] == "n")
                    {
                        i = 5;
                    }
                    if (waffles[0].Equals("y"))
                        Items.Add(waffles);
                }
                while (drinks[0] != "n")
                {
                    Console.WriteLine(questionsD[j]);
                    drinks[j] = Console.ReadLine();
                    j++;

                    if (j == 3)
                    {
                        j = 0;

                    }
                    if(drinks[0].Equals("y"))
                       Items.Add(drinks);
                }
            }
        }

        //clone a previous order
        public object Clone()
        {
            Order o = ArchivedInfo.Retrieve(OldDate);
            w = new(o);
            return o;
        }


    }
}
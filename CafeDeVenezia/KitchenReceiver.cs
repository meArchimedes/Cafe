using CafeDeVenezia.Drinks___Abs_Factory;
using CafeDeVenezia.Waffles___Decorator;
using CafeDeVenezia;
using CafeDeVenezia.Waffles___Decorator.Shape___Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeDeVenezia
{
    internal class KitchenReceiver
    {
        public static void PassOrder_Waffle(string[] commands)
        {
            Waffle w;
            Shape shape = new Square();
            Waffle endW = new Waffle(shape);

            
            if (commands[1].ToString().Equals("s"))                    //Square
            {
                w = new Waffle(shape);

            }
            else                                                       //Round(Default)
            {
                shape = new Round();
                w = new Waffle(shape);
                endW.SetShape(shape);
            }
            if (commands[2].ToString().Equals("y"))                    //Wants Syrups
            {
                if (commands[3].ToString().Equals("y"))                //And Buttersotch
                {
                    Butterscotch b = new(w, shape);
                    if (commands[4].ToString().Equals("y"))            //And Milk Chocolate
                    {
                        MilkChocolate m = new(b, shape);
                        endW = m;
                    }
                }
                else                                                   //No Butterscotch
                {
                    if (commands[4].ToString().Equals("y"))            //Milk Chocolate
                    {
                        MilkChocolate m = new(w, shape);
                        endW = m;
                    }
                }
            }
            if (commands[5].ToString().Equals("y"))                     //Wants Toppings
            {
                if (commands[6].ToString().Equals("y"))                 //Wants Oreo Crumbs
                {
                    if (commands[7].ToString().Equals("y"))             //Wants M&M's
                    {
                        Mn_m_s mn = new(w, shape);
                        if (commands[7].ToString().Equals("y"))         //Wants Ice Cream
                        {
                            IceCreamScoop ics = new(mn, shape);
                            endW = ics;
                        }
                    }
                    else                                                //No M&M's
                    {
                        if (commands[7].ToString().Equals("y"))         //Wants Ice Cream
                        {
                            IceCreamScoop ics = new(endW, shape);
                            endW = ics;
                        }
                    }
                }
                else                                                    //No Oreo Crumbs
                {
                    if (commands[7].ToString().Equals("y"))             //Wants M&M's
                    {
                        Mn_m_s mn = new(w, shape);
                        if (commands[7].ToString().Equals("y"))         //Wants Ice Cream
                        {
                            IceCreamScoop ics = new(mn, shape);
                            endW = ics;
                        }
                    }
                    else                                                //No M&M's
                    {
                        if (commands[7].ToString().Equals("y"))         //Wants Ice Cream
                        {
                            IceCreamScoop ics = new(endW, shape);
                            endW = ics;
                        }
                    }
                }
            }
            Order.price = endW.GetPrice();
            Order.details = endW.Print();
        }
        public static void PassOrder_Drink(string[] commands)
        {
            BeverageFactory drink = new HotBeveragefactory();
            if (int.Parse(commands[2]) == 2)
            {
                drink = new ColdBeverageFactory();
            }
            
            int DrinkType = int.Parse(commands[1]);
            switch (DrinkType)
            {
                case 1:
                    drink.CreateCoffee();
                    break;
                case 2:
                    drink.CreateTea();
                    break;
                case 3:
                    drink.CreateCocoa();
                    break;
            }
            Order.price += drink.GetPrice();
            Order
                .details += $"\n{drink.GetType}";
        }


        public static void WorkOffRequests(List<string[]> tasks, Order o)
        {
            o.state.AdvanceState();
            o.state.CurrentState();
            foreach (var item in tasks)
            {
                if (item.Length == 9)
                {
                    PassOrder_Waffle(item);
                }
                else
                {
                    PassOrder_Drink(item);
                }
            }
            
        }
    }
}


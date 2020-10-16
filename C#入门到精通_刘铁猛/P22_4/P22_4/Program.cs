using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P22_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            // customer.Order += waiter.Action;
            customer.Order += new EventHandler(waiter.Action);

            //   OrderEventArgs e = new OrderEventArgs();
            //   e.DishName = "Manhanquanxi";
            //   e.Size = "large";
            //
            //   OrderEventArgs e2 = new OrderEventArgs();
            //   e2.DishName = "Beer";
            //   e2.Size = "large";
            //
            //   Customer badGuy = new Customer();
            //   badGuy.Order += waiter.Action;
            //   badGuy.Order.Invoke(customer, e);
            //   badGuy.Order.Invoke(customer, e2);

            customer.Action();
            customer.PayTheBill();
        }
    }

 //   public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

    public class OrderEventArgs : EventArgs
    {
        public string DishName { get; set; }
        public string Size { get; set; }
    }

    public class Customer
    {
        // private OrderEventHandler orderEventHandler;
        // public event OrderEventHandler Order
        // {
        //     add
        //     {
        //         this.orderEventHandler += value;
        //
        //     }
        //     remove
        //     {
        //         this.orderEventHandler -= value;
        //     }
        // }

        public event EventHandler Order;

        public double Bill { get; set; }
        public void PayTheBill()
        {
            Console.WriteLine("I will pay ${0}.", this.Bill);
        }

        public void WalkIn()
        {
            Console.WriteLine("Walk int the restaurant.");
        }

        public void SitDown()
        {
            Console.WriteLine("Sit down.");
        }

        public void Think()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Let me think...");
                Thread.Sleep(1000);
            }

            this.OnOrder("Gongbao Chicken", "large");
            
        }

        protected void OnOrder(string dishName, string size)
        {

            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishName;
                e.Size = size;
                this.Order.Invoke(this, e);
            }
        }

        public void Action()
        {
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }

    }

    public class Waiter
    {
        internal void Action(object sender, EventArgs e)
        {
            Customer customer = sender as Customer;
            OrderEventArgs orderInfo = e as OrderEventArgs;
            Console.WriteLine("I will serve you the dish - {0}.", orderInfo.DishName);
            double price = 10;
            switch (orderInfo.Size)
            {
                case "small":
                    price = price * 0.5;
                    break;
                case "large":
                    price = price * 1.5;
                    break;
                default:
                    break;
            }

            customer.Bill += price;

        }
    }
}

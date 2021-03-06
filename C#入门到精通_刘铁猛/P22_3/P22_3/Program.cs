﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P22_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;

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

    public delegate void OrderEventHandler(Customer customer, OrderEventArgs e);

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

        public event OrderEventHandler Order;

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

            if (this.Order != null)
            {
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = "Kongpao Chicken";
                e.Size = "large";
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
        internal void Action(Customer customer, OrderEventArgs e)
        {
            Console.WriteLine("I will serve you the dish - {0}.", e.DishName);
            double price = 10;
            switch (e.Size)
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

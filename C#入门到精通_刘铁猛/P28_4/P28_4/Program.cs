using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P28_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new PhoneUser(new NokiaPhone());
            user.UsePhone();
            var user2 = new PhoneUser(new EricssonPhone());
            user2.UsePhone();
        }
    }

    class PhoneUser
    {
        private IPhone _phone;
        public PhoneUser(IPhone phone)
        {
            _phone = phone;
        }
        public void UsePhone()
        {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();
        }
    }

    // 引入接口后，接口就会变得非常非常的松。即低耦合
    // 反射能做到更松的耦合。
    interface IPhone
    {
        void Dail();
        void PickUp();
        void Send();
        void Receive();

    }

    class NokiaPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Nokia calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hello! This is Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Nokia message ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : IPhone
    {
        public void Dail()
        {
            Console.WriteLine("Ericsson calling ...");
        }

        public void PickUp()
        {
            Console.WriteLine("Hi! This's Tim!");
        }

        public void Receive()
        {
            Console.WriteLine("Ericsson ring ...");
        }

        public void Send()
        {
            Console.WriteLine("Good evening!");
        }
    }
}

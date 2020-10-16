using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Car();
            v.Run();
            Console.WriteLine(v.Speed);

        }
    }
    class Vehicle
    {
        private int _speed;
        public virtual int Speed { 
            get { return _speed; }
            set { _speed = value; } 
        }
        public virtual void Run()
        {
            Console.WriteLine("I'm running!");
            _speed = 100;
        }
    }

    class Car : Vehicle
    {
        private int _rpm;
         public override int Speed { get { return _rpm / 100; } set { _rpm = value * 100; } }

        // 在父类成员上标记为virtual
        //在子类成员上标记为override。则为重写
        // 如果父类和子类有同一个函数，则为隐藏。相当于子类有两个一模一样的函数
        public override void Run()
        {
            Console.WriteLine("Car is running!");
            _rpm = 50000;
        }
    }

    class RaseCar : Car
    {
        public override void Run()
        {
            Console.WriteLine("Rase car is running!");
        }
    }
}

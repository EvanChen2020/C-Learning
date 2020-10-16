using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P26_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vehicle();
            v.Run();
            var c = new Car();
            c.Run();

            Vehicle v1 = new Car();
            v1.Run();

            // 父类引用子类的实例，总能调用子类最新的版本。这就是多态
            Vehicle v2 = new RaseCar();
            v2.Run();

        }
    }
    class Vehicle
    {
        public virtual  void Run()
        {
            Console.WriteLine("I'm running!");
        }
    }

    class Car : Vehicle
    {
      //  public int Speed { get; set; }

            // 在父类成员上标记为virtual
            //在子类成员上标记为override。则为重写
            // 如果父类和子类有同一个函数，则为隐藏。相当于子类有两个一模一样的函数
        public override void Run()
        {
            Console.WriteLine("Car is running!");
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

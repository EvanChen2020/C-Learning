using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Evan");

            // 构造器是先运行基类的构造器，然后在运行派生类的构造器
            Console.WriteLine(car.Owner);

        }
    }

    class Vehicle
    {
        public Vehicle(string owner)
        {
            this.Owner = owner;
        }
        public string Owner { get; set; }
    }

    //子类对父类成员全盘继承
    class Car : Vehicle
    {

        // 如果子类构造器不想带参数，只能子类构造器给出一个父类带参数的调用
      //  public Car():base("N/A")
      //  {
      //
      //      this.Owner = "Car Owner";
      //  }

            // 构造器是不被继承的
            public Car(string owner) : base(owner)
        {

        }

        public void ShowOwner()
        {
            Console.WriteLine(this.Owner);
            // 只能访问上一级，即只能由base. 而不能有base.base.
            Console.WriteLine(base.Owner);
        }
    }

}

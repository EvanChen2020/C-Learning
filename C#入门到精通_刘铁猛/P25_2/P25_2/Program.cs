using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P25_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            // 构造器是先运行基类的构造器，然后在运行派生类的构造器
            Console.WriteLine(car.Owner);

        }
    }

    class Vehicle
    {
        public Vehicle()
        {
            this.Owner = "N/A";
        }
        public string Owner { get; set; }
    }

    //子类对父类成员全盘继承
    class Car : Vehicle
    {
        public Car(){

            this.Owner = "Car Owner";
            }

        public void ShowOwner()
        {
            Console.WriteLine(this.Owner);
            // 只能访问上一级，即只能由base. 而不能有base.base.
            Console.WriteLine(base.Owner);
        }
    }

    class RaceCar: Car
    {

    }
}

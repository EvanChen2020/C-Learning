using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type t = typeof(Car);
            // Type tb = t.BaseType;
            // Console.WriteLine(tb.FullName);
            // Type tbTop = tb.BaseType;
            // Console.WriteLine(tbTop.FullName);
            // Console.WriteLine(tbTop.BaseType==null);

            // 是一个概念 is a
            // 一个子类的实例，从语义上来说也是一个父类的实例
            // 一个派生类的实例，也是基类的一个实例
            // 反过来不能说
            //.net 所有的类都是单根的

          // Car car = new Car();
          // Console.WriteLine(car is Vehicle);
          // Console.WriteLine(car is object);

            //下面这些写法都是没有问题的
            Vehicle vehicle = new Car();
            Object o1 = new Vehicle();
            Object o2 = new Car();

        }
    }
    // sealed 表示不能派生类
  // sealed class Vehicle
        class Vehicle
    {

    }
    class Toy
    {

    }

    //一个类不能从两个类派生出来，基接口可以有多个
        //class Car: Vehicle,Toy

//子类的访问级别不能高于父类。但可以一样或范围缩小
        class Car : Vehicle
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Car();
            v.Run();
            Vehicle v1 = new Truck();
            v1.Run();
            Vehicle r = new RaceCar();
            r.Run();
        }
    }

    //在C#里面，纯抽象类其实就是接口
    //  abstract class VehicleBase
    //  {
    //      abstract public void Stop();
    //      abstract public void Fill();
    //      abstract public void Run();
    //  }

        //在接口里面，要求所有的成员必须是public，所以默认的pulic就可以省略。
    //接口本来就包括了是纯抽象类的涵义，所以所有的程序员必定是抽象的。所以abstract也是可以省略的
    // 这个不能单单说省略，而是必须去掉。
    // 省略了abstract，那么实现的过程中，就不需要override了
    // 接口命名，一般以I开头
   //   interface  VehicleBase
          interface IVehicle
    {
          void Stop();
          void Fill();
          void Run();
      }


    //抽象类专为做基类而生的
    // 如果没有完全实现接口，还需要保留一个abstract的方法
    abstract class Vehicle: IVehicle
    {
      //  public override void Stop()
            public  void Stop()
        {
            Console.WriteLine("Stopped!");
        }

       // public override void Fill()
            public  void Fill()
        {
            Console.WriteLine("Pay and fill ...");
        }

        abstract public void Run();

        //  public void Run(string type)
        //  {
        //      if (type == "car")
        //      {
        //          Console.WriteLine("Car is running ...");
        //      }
        //      else if (type == "truck")
        //      {
        //
        //      }
        //  }

        // public virtual void Run()
        // {
        //   Console.WriteLine("Vehicle is running ...");
        // }

        // 完全没有方法体，叫纯需方法
        // public virtual void Run()
        // {
        // }

       // public abstract void Run();
     }
    class Car : Vehicle
    {
        //public override void Run()
            public override void Run()
        {
            Console.WriteLine("Car is running ...");
        }
    }

    class Truck : Vehicle
    {
       // public override void Run()
             public override void Run()
        {
            Console.WriteLine("Truck is running ...");
        }
    }

    class RaceCar : Vehicle
    {
        // public override void Run()
        public override void Run()
        {
            Console.WriteLine("Race car is running ...");
        }
    }
}

// 为做基类而生的“抽象类”与“开放/关闭原则”

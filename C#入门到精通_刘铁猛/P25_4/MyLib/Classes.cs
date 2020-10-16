using System;

namespace MyLib
{

    // 类的访问级别是类成员访问级别的上限
    public class Classes
    {
    }

   public class Vehicle
    {
        // public string Owner { get; set; }
        // internal string Owner { get; set; }
        // 只能在基类中访问
        // 默认的访问类型就是private
        private string Owner { get; set; }

       //  private int _rpm;
        protected int _rpm;
        private int _fuel;

        public void Refuel()
        {
            this._fuel = 100;
        }
        // protected只在这个继承链上可以使用,更多的是使用在方法上。而且跨程序集 可以和internal组合使用。两个是或的关系
        protected void Burn(int fuel)
        {
            _fuel-=fuel;
        }

        public void Accelerate()
        {
            Burn(1);
            _rpm += 1000;
        }

        public int Speed { get { return _rpm / 100; }  }

    }

    public class Car : Vehicle
    {
      // public void ShowOwner()
      // {
      //   //  Console.WriteLine(base.Owner);
      // }


        public void TurboAccelerate()
        {
            Burn(2);
           _rpm += 3000;
        }
    }

    public class C
    {

    }

}

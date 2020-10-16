using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P28_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new Engine();
            var car = new Car(engine);
            car.Run(3);
            Console.WriteLine(car.Speed);
        }
    }
    // 这个是紧耦合.如果engine出问题了,所有的程序都出问题了.而且问题的根本原因也很难找到
    class Engine
    {
        public int RPM { get; private set; }
        public void Work(int gas)
        {
            this.RPM = 1000 * gas;
        }
    }

    class Car
    {
        private Engine _engine;
        public Car(Engine engine)
        {
            _engine = engine;
        }

        public int Speed { get;private set; }
        public void Run(int gas)
        {
                            _engine.Work(gas);
                this.Speed = _engine.RPM / 100;
        }
    }
}

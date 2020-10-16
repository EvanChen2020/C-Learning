using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace P25_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicle vehicle = new Vehicle();
            // vehicle.Owner = "Timothy";
            // Console.WriteLine(vehicle.Owner);

            Car car = new Car();
            //   car.Accelerate();
            //   car.Accelerate();
            //   Console.WriteLine(car.Speed);

            //  car.Refuel();
            //  car.TurboAccelerate();
            //  Console.WriteLine(car.Speed);

            Bus bus = new Bus();
            bus.SlowAccelerate();
            Console.WriteLine(bus.Speed);
        }
    }

    class Bus : Vehicle
    {
        public void SlowAccelerate()
        {
            Burn(1);
            _rpm += 500;
        }
    }
}

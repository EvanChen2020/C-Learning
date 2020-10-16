using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(new Car());
            driver.Drive();

            var driver2 = new Driver(new HeavyTank());
            driver2.Drive();
        }
    }
    class Driver
    {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void Drive()
        {
            _vehicle.Run();
        }
    }
    interface IVehicle
    {
        void Run();
    }

    class Car : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Car is running ...");
        }
    }

    class Truck : IVehicle
    {
        public void Run()
        {
            Console.WriteLine("Truck is running ...");
        }
    }
    interface IWeapon
    {
        void Fire();
    }

  // interface ITank
  // {
  //     void Fire();
  //     void Run();
  // }

    interface ITank:IVehicle, IWeapon
    {

    }

    class LightTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka ka ka ...");
        }
    }

    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka! ka! ka! ...");
        }
    }

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Boom!!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka!! ka!! ka!! ...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P29_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ITank tank = new HeavyTank();
            // ===============华丽的分割线=============
            // 大部分的时候，我们用反射不会这么直接去用，而是会去用封装好的反射。即依赖注入
            var t = tank.GetType();
            object o = Activator.CreateInstance(t);
            MethodInfo fireMi = t.GetMethod("Fire");
            MethodInfo runMi = t.GetMethod("Run");
            fireMi.Invoke(o, null);
            runMi.Invoke(o, null);
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

    interface IWeapon
    {
        void Fire();
    }

    interface ITank:IVehicle, IWeapon
    {

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

    class HeavyTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Bom!!, bom!!");        }

        public void Run()
        {
            Console.WriteLine("Ka!!, ka!!");
        }
    }
}

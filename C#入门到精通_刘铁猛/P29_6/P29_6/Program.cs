using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace P29_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var sc = new ServiceCollection();
           // sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped(typeof(ITank), typeof(MediumTank));
           // sc.AddScoped(typeof(IVehicle), typeof(Car));
           // 用注册的类名，放入到了注册器之中
            sc.AddScoped(typeof(IVehicle), typeof(HeavyTank));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();
            // ===================华丽的分隔线=================
            // 通过依赖注入只需要将HeavyTank改成MediumTank。程序中别的地方不需要做任何更改。
            ITank tank = sp.GetService<ITank>();
            tank.Fire();
            tank.Run();

            var driver = sp.GetService<Driver>();
            driver.Drive();

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

    interface ITank : IVehicle, IWeapon
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
            Console.WriteLine("Bom!!, bom!!");
        }

        public void Run()
        {
            Console.WriteLine("Ka!!, ka!!");
        }
    }

    class MediumTank : ITank
    {
        public void Fire()
        {
            Console.WriteLine("Bom!, bom!");
        }

        public void Run()
        {
            Console.WriteLine("Ka!, ka!");
        }
    }
}

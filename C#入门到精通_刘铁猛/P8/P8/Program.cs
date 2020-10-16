using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8
{
    
    class Program
    {
        static void Main(string[] args)
        {
          //  Calculator c = new Calculator();
            Console.WriteLine(Calculator.GetCircleArea(10));
        }
    }

    class Calculator
    { 
        public static double GetCircleArea(double r)
        {
            // return 3.14 * r * r;
            return Math.PI * r * r;
        }
        public static   double  GetCylinderVolume(double r, double h)
        {
            // return 3.14 * r * r * h;
            return GetCircleArea(r) * h;
        }

        public static double GetConeVolume(double r, double h)
        {
            // return 3.14 * r * r * h * 1 / 3;
            return GetCylinderVolume(r, h) / 3;
        }
    } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(3.0, 4.0);
        }

        static double Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine("Result is {0}.", result);
            return result;
        }
    }
}

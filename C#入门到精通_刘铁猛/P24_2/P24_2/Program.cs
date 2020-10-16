using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib.MyNamespace;

namespace P24_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            double res = calc.Add(1.1, 2.2);
            Console.WriteLine(res);
        }
    }
}

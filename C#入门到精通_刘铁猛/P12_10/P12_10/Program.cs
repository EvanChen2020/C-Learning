using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int z = 7;
            int a = x += y *= z;
            Console.WriteLine(a);
        }
    }
}

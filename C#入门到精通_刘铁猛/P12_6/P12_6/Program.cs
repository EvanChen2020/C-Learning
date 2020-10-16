using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            double y = 4.0;
            var result = x < y;
            Console.WriteLine(result.GetType().FullName);
            Console.WriteLine(result);

        }
    }
}

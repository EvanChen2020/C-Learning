using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 28;
            int z = x ^ y;
            string strX = Convert.ToString(x, 2).PadLeft(32, '0');
            string strY = Convert.ToString(y, 2).PadLeft(32, '0');
            string strZ = Convert.ToString(z, 2).PadLeft(32, '0');
            Console.WriteLine(strX);
            Console.WriteLine(strY);
            Console.WriteLine(strZ);
        }
    }
}

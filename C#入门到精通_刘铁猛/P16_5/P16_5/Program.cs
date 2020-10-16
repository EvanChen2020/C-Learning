using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <=9; a++)
            {
               
                for (int b = 1; b <=a; b++)
                {
                  //  if (b > a)
                  //      break;
                    // Console.WriteLine("{0}x{1}={2}",a,b,a*b);
                    Console.Write("{0}x{1}={2}\t", a, b, a * b);
                }
                Console.WriteLine();
            }
        }
    }
}

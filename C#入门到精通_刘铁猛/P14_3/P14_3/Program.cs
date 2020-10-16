using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 95;
            switch (score/10)
            {
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("A");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("B");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}

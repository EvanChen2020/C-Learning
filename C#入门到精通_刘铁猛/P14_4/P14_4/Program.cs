using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Level myLevel = Level.High;
            switch (myLevel)
            {
                case Level.High:
                    Console.WriteLine("High level!");
                    break;
                case Level.Mid:
                    Console.WriteLine("Mid level!");
                    break;
                case Level.Low:
                    break;
                default:
                    break;
            }
        }
    }

    enum Level
    {
        High,
        Mid,
        Low
    }
}

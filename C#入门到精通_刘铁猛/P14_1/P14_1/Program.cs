using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 55;
            if(score>=60)
                if(score>=85)
                    Console.WriteLine("Best!");
                else
                    Console.WriteLine("Good!");
            else
                Console.WriteLine("Failed!");
        }
    }
}

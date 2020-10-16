using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int ?x= null;
            int y = x ?? 1;
            Console.WriteLine(y);
        }
    }
}

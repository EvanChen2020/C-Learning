using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace P18_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 1;
            IWantSideEffect(ref y);
            Console.WriteLine(y);
        }

         static void IWantSideEffect(ref int x)
        {
            x = x + 100;
        }
    }
}

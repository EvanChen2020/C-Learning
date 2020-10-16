using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Tim;Tom,Amy.Lisa";
            string[] result = str.Split(';', ',', '.');
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}

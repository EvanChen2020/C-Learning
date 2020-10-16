using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            bool b = DoubleParser.TryParse("789", out x);
            if (b==true)
            {
                Console.WriteLine(x+1);
            }
        }
    }

    class DoubleParser
    {
        public static bool TryParse(string input, out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch 
            {

                result = 0;
                return false;
            }
        }
    }

}

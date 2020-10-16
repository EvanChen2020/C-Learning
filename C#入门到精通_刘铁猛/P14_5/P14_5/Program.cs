using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
           // int r = c.Add(null, "200");
           // int r = c.Add("abc", "200");
            int r = c.Add("999999999999999999999", "200");
            Console.WriteLine(r);
        }
    }

    class Calculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);

            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Your argument(s) are null");
            }
            catch (FormatException)
            {
                Console.WriteLine("Your argument(s) are not number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Out of range!");
            }

            int result = a + b;
            return result;
        }
    }
}

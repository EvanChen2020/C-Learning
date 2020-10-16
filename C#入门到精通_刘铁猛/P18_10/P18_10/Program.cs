using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] myIntArray = new int[] { 1, 2, 3 };
            // int result = CalculateSum(myIntArray);
            int result = CalculateSum(1, 2, 3,5);
            Console.WriteLine(result);
        }

        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 11, 12,10, 13, 14, 15 };
            bool result = myList.All(i => i > 10);
            Console.WriteLine(result);
        }

        static bool AllGreaterThanTen(List<int> intList)
        {
            foreach (var item in intList)
            {
                if (item<=10)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

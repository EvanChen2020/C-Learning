using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5, 6 };
         
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6,7,8 };
            IEnumerator enumerator = intList.GetEnumerator();
            //  while (enumerator.MoveNext())
            //  {
            //      Console.WriteLine(enumerator.Current);
            //  }
            //  enumerator.Reset();
            //  while (enumerator.MoveNext())
            //  {
            //      Console.WriteLine(enumerator.Current);
            //  }
            foreach (var current in intList)
            {
                Console.WriteLine(current);
            }

        }
    }
}

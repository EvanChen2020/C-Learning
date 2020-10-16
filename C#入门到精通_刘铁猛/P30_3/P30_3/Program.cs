using System;
using System.Collections.Generic;

namespace P30_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //list 也叫动态数组 array list. 当他创建时，其实是先创建一个数组。满了之后，将老数组的数据copy到新数组里面去
            //重新创建一个新数组。所以list在某些地方，也叫做动态数组。
            IList<int> list = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(i);
            }
            // 很多泛型类和泛型成员都是带有两个或两个以上的参数的。


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}

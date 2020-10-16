using System;
using System.Collections;
using System.Collections.Generic;

namespace P30_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //有两个泛型参数的例子
            // 已经给出了T的类型，叫做特化后的泛型类/接口
            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "Timothy";
            dict[2] = "Michael";
            // $这个叫字符串模板
            Console.WriteLine($"Student #1 is {dict[1]}");
            Console.WriteLine($"Student #2 is {dict[2]}");
        }
    }
}

using System;

namespace P31_4
{
    class Program
    {
        static void Main(string[] args)
        {
           // Func<int, int, int> func = new Func<int, int, int>((int a, int b) => { return a + b; });
           // //(int a, int b) => { return a + b; } 这个就是Lambda表达式
           // int res = func(100, 200);
           // Console.WriteLine(res);
           //
           // func = new Func<int, int, int>((int x, int y) => { return x * y; });
           // res = func(3, 4);
           // Console.WriteLine(res);

            //省略数据类型
         //  Func<int, int, int> func = new Func<int, int, int>(( a,  b) => { return a + b; });
         //  //(int a, int b) => { return a + b; } 这个就是Lambda表达式
         //  int res = func(100, 200);
         //  Console.WriteLine(res);
         //
         //  func = new Func<int, int, int>(( x,  y) => { return x * y; });
         //  res = func(3, 4);
         //  Console.WriteLine(res);

            //省略表达式的声明
            Func<int, int, int> func = (a, b) => { return a + b; };
            //(int a, int b) => { return a + b; } 这个就是Lambda表达式
            int res = func(100, 200);
            Console.WriteLine(res);

            func = (x, y) => { return x * y; };
            res = func(3, 4);
            Console.WriteLine(res);
        }
    }
}

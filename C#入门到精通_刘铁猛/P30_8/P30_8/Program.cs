using System;

namespace P30_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lambd 表达式，对那些非常简单的方法，不去申明真实的方法。而是谁调用，谁申明。而且
            //属于匿名的申明
            Func<double, double, double> func1 = (double a, double b) => { return a + b; };
            // 再一次进行简化.因为前面Func已经告诉编译器，a和b肯定是double类型的参数了。
            Func<double, double, double> func2 = ( a,  b) => { return a + b; };
            var result = func1(100.1, 200.2);
            Console.WriteLine(result);

            var result2 = func2(100.1, 200.2);
            Console.WriteLine(result2);
        }
    }
}

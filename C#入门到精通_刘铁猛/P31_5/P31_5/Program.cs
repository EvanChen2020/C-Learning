using System;

namespace P31_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
           // DoSomeCalc<int>((int a, int b) => { return a * b; }, 100, 200);
           // 因为int类型是可以推断出来的。所以int可以省略掉
           // DoSomeCalc<int>(( a, b) => { return a * b; }, 100, 200);
           // 因为传进来100和200是标准的整数，所以编译器可以推断T为int类型。这个就叫泛型委托的类型推断
            DoSomeCalc((a, b) => { return a * b; }, 100, 200);
        }

        static void DoSomeCalc<T>(Func<T,T,T> func, T x, T y)
        {
            T res =func(x, y);
            Console.WriteLine(res);
        }
    }
}

//总结
// 什么是委托？
// 委托类型是怎么声明出来的？
//泛型委托
//我们必须自己创建委托类型吗？
//泛型委托的类型参数推断
//===================
//方法与Lambda表达式之间的关系
//如何把一个Lambda表达式赋值给一个委托类型变量
//如何把一个Lambda表达式“喂”给一个委托类型参数
//================
// LINQ
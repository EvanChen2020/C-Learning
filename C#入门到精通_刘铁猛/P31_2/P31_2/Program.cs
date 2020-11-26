using System;
using System.Runtime.CompilerServices;

namespace P31_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDele<int> deleAdd = new MyDele<int>(Add);
            int res = deleAdd(100, 200);
            Console.WriteLine(res);

            MyDele<double> deleMul = new MyDele<double>(Mul);
            double mulRes = deleMul(3.0, 4.0);
            Console.WriteLine(mulRes);
            //判断委托是不是类
            //所以，委托是一个特殊的类类型
            Console.WriteLine(deleAdd.GetType().IsClass);

            //C#里面本身就又一些泛型委托用，其实不需要直接自己去声明去使用
            Action action = new Action(M1);
            action();

            Action<string>  action2 = new Action<string>(SayHello);
            action2("Tim");

            Action<string, string> action3 = new Action<string, string>(SayHello);
            action3("Evan", "Peter");


            Func<int, int, int> func = new Func<int, int, int>(Add);
            int res2 = func(100, 200);
            Console.WriteLine(res2);

            var func2 = new Func<double, double, double>(Mul);
            double res3 = func2(3.0, 4.0);
            Console.WriteLine(res3);


        }

        static void M1()
        {
            Console.WriteLine("M1 is called.");
        }

        static void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        static void SayHello(string name1, string name2)
        {
            Console.WriteLine($"Hello, {name1} and {name2}!!");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }
    }

    //泛型委托
    delegate T MyDele<T>(T a, T b);


}

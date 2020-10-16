using System;

namespace P30_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 泛型委托
            //常用的是Action的泛型委托和Function泛型委托

            // 通过委托去嗲用一个方法，叫做间接调用
            Action<string> a1 = Say;
            a1.Invoke("Timothy");
            a1("Timothy");
            Action<int> a2 = Mul;
            a2(1);
        }

        static void Say(string str)
        {
            Console.WriteLine($"Hello, {str}");
        }

        static void Mul(int x)
        {
            Console.WriteLine(x*100);
        }
    }
}

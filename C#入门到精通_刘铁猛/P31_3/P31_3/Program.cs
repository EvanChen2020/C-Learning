using System;

namespace P31_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda
            //1,匿名方法
            //2，Inline方法
            //这个Add方法，是先声明后调用
            //那么Inline则是在用的时候才声明
            int res = Add(100, 200);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

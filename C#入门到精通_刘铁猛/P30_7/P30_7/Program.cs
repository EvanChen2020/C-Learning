using System;

namespace P30_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> intAdd = Add;
            var result = intAdd(100, 200);
            Console.WriteLine(result);

            Func<Double, Double, Double> doubleAdd = Add;
            var result2 = doubleAdd(100.1, 200.2);
            Console.WriteLine(result2);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
    }
}

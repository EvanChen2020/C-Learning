using System;
using System.IO.Compression;

namespace P30_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = { 1, 2, 3, 4, 5 };
            int[] a2 = { 1, 2, 3, 4, 5, 6 };
            double[] a3 = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] a4 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            var result = Zip(a1, a2);
            Console.WriteLine(string.Join(",",result));
           var result2 = Zip(a3, a4);
            Console.WriteLine(string.Join(",", result2));
            //如果每增加一种类型，就增加一个方法，那么，就会出现成员字段膨胀
            //下面则是泛型方法的调用
            var result3 = Zip(a1, a2);
          //  result3 = Zip<int>(a1, a2);
            Console.WriteLine(string.Join(",", result3));
            var result4 = Zip(a3, a4);
            Console.WriteLine(string.Join(",", result4));



        }

        static int[] Zip(int[] a, int[] b)
        {
            int[] zipped = new int[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai<a.Length)
                {
                    zipped[zi++] = a[ai++];

                }
                if (bi < b.Length) zipped[zi++] = b[bi++];

            } while (ai<a.Length||bi<b.Length);
            return zipped;
        }

        static double[] Zip(double[] a, double[] b)
        {
            double[] zipped = new double[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length)
                {
                    zipped[zi++] = a[ai++];

                }
                if (bi < b.Length) zipped[zi++] = b[bi++];

            } while (ai < a.Length || bi < b.Length);
            return zipped;
        }

        //采用泛型成员
        //T要加在方法名后面
        static T[] Zip<T>(T[] a, T[] b)
        {
            T[] zipped = new T[a.Length + b.Length];
            int ai = 0, bi = 0, zi = 0;
            do
            {
                if (ai < a.Length)
                {
                    zipped[zi++] = a[ai++];

                }
                if (bi < b.Length) zipped[zi++] = b[bi++];

            } while (ai < a.Length || bi < b.Length);
            return zipped;
        }
    }
}

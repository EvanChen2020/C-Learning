using System;

namespace P31_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //我们在写程序时，会有这么一种情况。在遇到某个触发时，我们需要调用一个函数，而这个
            //函数又不确定。这个时候我们就需要用到委托
            //在C/C++里面，则使用的是函数指针
            //Java里面，则需要用指针来做
            MyDele dele1 = new MyDele(M1);
            Student stu = new Student();
            //委托的多播
            dele1 += M1;
            dele1 += stu.SayHello;
            dele1.Invoke();
            dele1();

            MyDele2 dele2 = new MyDele2(Add);
            int res = dele2(100, 200);
            Console.WriteLine(res);
        }

        static void M1()
        {
            Console.WriteLine("M1 is called!");
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

    }

    class Student
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, I'm a student!");
        }
    }

    //声明委托
    delegate void MyDele();
    delegate int MyDele2(int a, int b);
}

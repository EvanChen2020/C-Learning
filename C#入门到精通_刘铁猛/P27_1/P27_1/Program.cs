using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P27_1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // 一个类里面，如果有抽象方法，就必须是抽象类。类就必须用abstract修饰
    // 抽象类，即函数成员没有被完全实现的类。与抽象类对应的则是具体类
    // 这个类中，有若干个函数成岩，但至少有一个成员是抽象成员
    abstract class Student
    {
        abstract public void Study();
    }
}

// 为做基类而生的“抽象类”与“开放/关闭原则”







using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib.MyNamespace
{
    //就算是一个空类，也是继承于object的
    // 前面没有任何修饰符时，等于加了internal
    // internal 在当前这个项目内可以访问，即项目访问级别 英文叫Assembly级别
    // 每一个项目，编译完成后就是一个程序集。库以dll结尾。有main函数的一般以exe结尾
    // public 则当别人引用这个命名空间时，这个类别人也可以使用
    //internal class Calculator
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}

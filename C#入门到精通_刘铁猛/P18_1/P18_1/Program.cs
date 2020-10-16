using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            int y = 100;
            stu.AddOne(y);
            Console.WriteLine(y);
        }
    }

    class Student
    {
        public void AddOne(int x)
        {
            x = x + 1;
            Console.WriteLine(x);
        }
    }
}

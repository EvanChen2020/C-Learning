using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student oldStu = new Student() { Name = "Tim" };
            SomeMethod(oldStu);
            Console.WriteLine("{0}, {1}", oldStu.GetHashCode(), oldStu.Name);
        }

        static void SomeMethod(Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine("{0}, {1}",stu.GetHashCode(),stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
    }
}

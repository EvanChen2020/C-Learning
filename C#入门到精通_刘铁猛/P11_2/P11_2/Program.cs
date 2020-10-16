using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.Report();
            CsStudent csStu = new CsStudent();
            csStu.Report();
        }
    }

    class Student
    {
        public void Report()
        {
            Console.WriteLine("I'm a student.");
        }
    }

    class CsStudent : Student
    {
        new public void Report()
        {
            Console.WriteLine("I'm CS student");
        }
    }
}

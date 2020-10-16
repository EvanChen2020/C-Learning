using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student(null);
            Console.WriteLine(stu.Name == null);
        }
    }

    class Student
    {
        public Student(string initName)
        {
            if (!string.IsNullOrEmpty(initName))
            {
                this.Name = initName;
            }

        }
        public string Name;
    }

   
    }

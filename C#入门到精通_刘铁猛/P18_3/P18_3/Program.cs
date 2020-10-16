using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P18_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student() { Name = "Tim" };
            UpdateObject(stu);
            Console.WriteLine("Hashcode={0}, Name={1}", stu.GetHashCode(), stu.Name);
        }

        static void UpdateObject(Student stu)
        {
            stu.Name = "Tom";
            Console.WriteLine("Hashcode={0}, Name={1}", stu.GetHashCode(),stu.Name);
        }
    }

    class Student
    {
        public string Name { get; set; }
        
    }
}

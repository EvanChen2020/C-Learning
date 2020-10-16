using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace P23_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Student.Amount);
            Student s1 = new Student(1, "Timothy");
            Student s2 = new Student(2, "Timothy");
            Console.WriteLine(Student.Amount);
        }
    }


    class Student
    {
        public static int Amount { get; set; }

        //静态构造器
       static Student()
        {
            Amount = 100;
        }
        //和类的名字一样，叫实例构造器。 ctor 为快捷键
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            Amount++;
        }

        // ~代表是析构器。名字与类命一样。
        ~Student()
        {
            Amount--;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public void Report()
        {
            // $字符串的解析
            Console.WriteLine($"I'm #{ID} student, my name is {Name}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P23_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //{}里面的叫初始化器
            //  //Student stu = new Student() {ID=1,Name="Timothy" };
            //  Student stu = new Student(1, "Timothy") ;
            //  Console.WriteLine(stu.ID);
            //  Console.WriteLine(stu.Name);
            //  stu.Report();

            //  // 利用反射创建类
            //  Type t = typeof(Student);
            //  object o = Activator.CreateInstance(t, 1, "Timothy");
            //  //  Console.WriteLine(o.GetType().Name);
            //  Student stu = o as Student;
            //  // Student stu=(Student)o 两个都是强制类型转换
            //  Console.WriteLine(stu.Name);

            Type t = typeof(Student);
            dynamic stu = Activator.CreateInstance(t, 1, "Timothy");
            Console.WriteLine(stu.Name);

        }
    }

    class Student
    {
        //和类的名字一样，叫实例构造器。 ctor 为快捷键
        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        // ~代表是析构器。名字与类命一样。
        ~Student()
        {
            Console.WriteLine("Bye bye! Release the system resources ...");
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

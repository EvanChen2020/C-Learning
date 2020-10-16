using System;
using System.Xml.Schema;

namespace P30_10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { ID = 101, Name = "Evan" };
            //装箱
            object obj = student;

            //拆箱
            //值类型Copy的是整个值的存储空间，而不是一个简单的引用
            Student student2 = (Student)obj;
            Console.WriteLine($"#{student2.ID} Name:{student2.Name}");

            //经典面试题
            Console.WriteLine("======================");
            Student stu1 = new Student() { ID = 101, Name = "Evan" };
            Student stu2 = stu1;
            stu2.ID = 1001;
            stu2.Name = "Michael";
            Console.WriteLine($"#{stu1.ID} Name:{stu1.Name}");
            Console.WriteLine($"#{stu2.ID} Name:{stu2.Name}");
            stu1.Speak();
            stu2.Speak();

            Console.WriteLine("====================");
            Student stu3 = new Student(200, "Evan3");
            stu3.Speak();
        }
    }
    interface ISpeak
    {
        void Speak();
    }
    //结构体是可以实现接口的。
    //结构体不能由其它的类派生而来
    //结构体不能有显示的无参构造器
    struct Student:ISpeak
    {
        // //这就是显示的无参构造器
        // public Student()
        // {
        //
        // }

        public Student(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public void Speak()
        {
            Console.WriteLine($"I'm #{this.ID} student {this.Name}");
        }
    }
}

using System;

namespace P30_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Level = Level.Employee;
            Person boss = new Person();
            boss.Level = Level.Boss;

            Console.WriteLine(boss.Level>person.Level);
            Console.WriteLine(boss.Level);
            Console.WriteLine(person.Level);
            Console.WriteLine((int)Level.Employee);
            Console.WriteLine((int)Level.Manager);
            Console.WriteLine((int)Level.Boss);
            Console.WriteLine((int)Level.BigBoss);
            Console.WriteLine((int)Level.Employee2);
            Console.WriteLine((int)Level.Manager2);
            Console.WriteLine((int)Level.Boss2);
            Console.WriteLine((int)Level.BigBoss2);

            Person person1 = new Person();
            person1.Name = "Evan";
            person1.Level = Level.Employee;
            person1.Skill = Skill.Drive | Skill.Cook | Skill.Program | Skill.Teach;
            Console.WriteLine("=================");
            Console.WriteLine(person1.Skill);
            //判断一个人会不会做饭
            //这个就是枚举类型的比特位用法
            //当我们读取文件时，也会用比特位的方法去选择怎么读取
            Console.WriteLine((person1.Skill&Skill.Cook)==Skill.Cook);

        }
    }

    //防止程序员输入不合法的Level，即用枚举类型进行限制
    enum Level
    {
        Employee,
        Manager,
        Boss,
        BigBoss,
        Employee2=100,
        Manager2,
        Boss2=300,
        BigBoss2,

    }

    //可以按位取或
    enum Skill
    {
        Drive = 1,
        Cook = 2,
        Program = 4,
        Teach = 8,


    }

    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }

        public Skill Skill { get; set; }
    }
}

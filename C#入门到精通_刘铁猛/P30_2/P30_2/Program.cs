using System;

namespace P30_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student<int> stu = new Student<int>();
            // stu.ID = 101;
            // stu.Name = "Timothy";
            // Student<ulong> student = new Student<ulong>();
            // student.ID = 1000000000000;
            // student.Name="Timothy"

            // 提前实现泛型类， 那么声明方式就变化了
            Student stu = new Student();
            stu.ID = 10000000000000;
        }
    }

    interface IUnique<TId>
    {
        TId ID { get; set; }
    }

    // 接口是泛型类，类也必须是泛型类
    //  class Student<TId> : IUnique<TId>
    //  {
    //      public TId ID { get; set ; }
    //
    //      public string Name { get; set; }
    //  }


    // 如果实现了泛型类，那么类就不再是泛型类了
    class Student : IUnique<ulong>
    {
        public ulong ID { get; set; }

        public string Name { get; set; }
    }
}

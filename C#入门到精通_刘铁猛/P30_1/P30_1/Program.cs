using System;

namespace P30_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Apple apple = new Apple() { Color = "Red" };
            //  AppleBox box = new AppleBox() { Cargo = apple };
            //  Console.WriteLine(box.Cargo.Color);
            //
            //  Book book = new Book() { Name = "New Book" };
            //  BookBox bookBox = new BookBox() { Cargo = book };
            //  Console.WriteLine(bookBox.Cargo.Name);

            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "New Book" };
            Box<Apple> box1 = new Box<Apple>() { Cargo = apple };
            Box<Book> box2 = new Box<Book>() { Cargo = book };
            Console.WriteLine(box1.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);

        }
    }


    class Apple
    {
        public string Color { get; set; }

    }


    class Book
    {
        public string Name { get; set; }
    }

    // 类型膨胀。如果类越多，类就越多
   // class AppleBox
   // {
   //     public Apple Cargo { get; set; }
   // }
   //
   // class BookBox
   // {
   //     public Book Cargo { get; set; }
   // }

  // class Box
  // {
  //     // 会有成员膨胀。将来增加品种，那么属性就会增多
  //     public Apple Apple { get; set; }
  //     public Book Book { get; set; }
  //
  //     // 如果用object的时，如果调用时，则需要强制类型转换。访问类成员会非常麻烦
  //     public object Cargo { get; set; }
  //
  // }


    // 泛型类
    class Box<TCargo>
    {
        public TCargo Cargo { get; set; }
    }
}

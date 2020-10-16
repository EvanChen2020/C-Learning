using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Partial 类，可以减少类的派生
            // 我们要把那些不变的东西放在基类中。把需要改变的部分放在派生类里面去。
            //Partial 类可以放在不同的地方，升级的时候，只需要在一个地方进行升级。而这几个类合并起来还是那个类命。
            var dbContext = new BookstoreEntities();
            var books = dbContext.Table_1;
            foreach(var book in books)
            {
                Console.WriteLine(book.ID);
                Console.WriteLine(book.Name);
                Console.WriteLine(book.Price);
                Console.WriteLine(book.Report());
            }
        }
    }
}

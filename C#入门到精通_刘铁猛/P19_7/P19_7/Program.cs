using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_7
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toycarFactory = new ToyCarFactory();

            WrapFactory wrapFactory = new WrapFactory();

    

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(pizzaFactory, log);
            Box box2 = wrapFactory.WrapProduct(toycarFactory, log);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
        }
    }

    interface IProductFactory
    {
        Product Make();
    }

    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Piza";
            product.Price = 12;

            return product;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            product.Price = 100;
            return product;
        }
    }

    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("Product '{0}' creeated at {1}, Price is {2}", product.Name, DateTime.UtcNow, product.Price);

        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(IProductFactory productFactory, Action<Product> logCallback)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            if (product.Price >= 50)
            {
                logCallback(product);

            }

            box.Product = product;
            return box;

        }
    }

}

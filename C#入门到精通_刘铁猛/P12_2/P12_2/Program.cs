using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Human h = t;
            Animal a = h;
            a.Eat();
            h.Think();
            t.Teach();

        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Human: Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }

    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programmming.");
        }
    }
}

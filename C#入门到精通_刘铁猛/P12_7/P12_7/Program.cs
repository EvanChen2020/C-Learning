using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teacher t = new Teacher();
            // var result = t is Teacher;
            // Console.WriteLine(result.GetType().FullName);
            // Console.WriteLine(result);
            object o = new Teacher();
            Teacher t = o as Teacher;
            if (t!=null)
            {
                t.Teach();
            }

        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }


    }

    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }

    class Teacher: Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programming.");
        }
    }
}

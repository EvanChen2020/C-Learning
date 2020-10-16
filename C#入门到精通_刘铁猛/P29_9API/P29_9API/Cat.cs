using BabyStroller.SDK;
using System;

namespace P29_8_API
{
    [Unfinished]
    public class Cat:IAnimal

    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Meow!");
            }
        }
    }
}

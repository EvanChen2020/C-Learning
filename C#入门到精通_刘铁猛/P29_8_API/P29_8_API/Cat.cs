using System;

namespace P29_8_API
{
    public class Cat
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

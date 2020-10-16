using System;

namespace P29_8_API2
{
    public class Dog
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Woof!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace P29_8_API2
{
    public class Cow
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Moo!");
            }
        }
    }
}

﻿using BabyStroller.SDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace P29_8_API
{
    
    public class Sheep:IAnimal
    {
        public void Voice(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("Baa...");
            }
        }
    }
}

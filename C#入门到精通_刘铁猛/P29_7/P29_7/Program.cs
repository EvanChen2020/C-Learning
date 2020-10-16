using System;
using System.Collections.Generic;
using System.IO;
using System.Runti

namespace P29_7
{
    class Program
    {
     
        static void Main(string[] args)
        {
            // 程序所运行的文件夹
            //  Console.WriteLine(Environment.CurrentDirectory);
            var folder = Path.Combine(Environment.CurrentDirectory, "Animals");
            var files = Directory.GetFiles(folder);
            var animalTypes = new List<Type>();
            foreach (var file in files)
            {
                var assembly=AssemblyLoadContext.
            }
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_7
{
    class Program
    {
        static void Main(string[] args)
        {
           var result= WhoIsWho("Mr.Okay");
            Console.WriteLine(result);
        }

        static string WhoIsWho(string alias)
        {
            if(alias=="Mr.Okay")
            {
                return "Tim";
            }
            else
            {
                return "I don't know!";
            }
        }

        static void Greeting(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            Console.WriteLine("Hello, {0}!",name);

        }
    }
}

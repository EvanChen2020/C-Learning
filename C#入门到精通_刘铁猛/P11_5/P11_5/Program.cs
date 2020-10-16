using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // int x = sizeof(double);
            // Console.WriteLine(x);
            unsafe
                {
                int x = sizeof(Student);
                Console.WriteLine(x);
            }
            
        }

        struct Student
        {
            int ID;
            long Score;
        }
    }
}

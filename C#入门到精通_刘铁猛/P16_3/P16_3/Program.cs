using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum = 0;    
            do
            {
                int x = 0;
                int y = 0;

                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();

                if(str1.ToLower()=="end")
                {
                    break;
                }


                try
                {
                     x = int.Parse(str1);
                }
                catch
                {
                    Console.WriteLine("First number has problem! Restart.");
                    continue;
                }
              

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();

                if (str2.ToLower() == "end")
                {
                    break;
                }

                try
                {
                    y = int.Parse(str2);
                }
                catch
                {
                    Console.WriteLine("Second number has problem! Restart.");
                    continue;
                }


                sum = x + y;
                if(sum==100)
                {
                    score++;
                    Console.WriteLine("Correct!{0}+{1}={2}", x,y,sum);

                }
                else
                {
                    Console.WriteLine("Error! {0}+{1}={2}",x,y,sum);
                  }
            } while (sum==100);
            Console.WriteLine("Your score is {0}",score);
            Console.WriteLine("Game Over!");
        }
    }
}

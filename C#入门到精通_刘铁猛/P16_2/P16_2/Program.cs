using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("Please input first number:");
                string str1 = Console.ReadLine();
                int x = int.Parse(str1);

                Console.WriteLine("Please input second number:");
                string str2 = Console.ReadLine();
                int y = int.Parse(str2);

                sum = x + y;
                if (sum == 100)
                {
                    score++;
                    Console.WriteLine("Correct! {0}+{1}={2}", x, y, sum);
                }
                else
                {
                    Console.WriteLine("Error! {0}+{1}={2}", x, y, sum);
                }
            } while (sum == 100);

            Console.WriteLine("Your score is {0}", score);
            Console.WriteLine("GAME OVER!");
        }
    }
}

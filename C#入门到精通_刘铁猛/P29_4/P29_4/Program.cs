using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P29_4
{
    class Program
    {
        static void Main(string[] args)
        {
            IKiller killer = new WarmKiller();
            killer.Kill();
            var wk = killer as WarmKiller;
            wk.Love();

        }
    }

    interface IGentlman
    {
        void Love();
    }

    interface IKiller
    {
        void Kill();
    }

    class WarmKiller : IGentlman, IKiller
    {
      

        public void Love()
        {
            Console.WriteLine("I will love you for ever ...");
        }

        // 显式的实现方法。只有接口为Ikiller时，才能看得到这个方法
        void IKiller.Kill()
        {
                 Console.WriteLine("Let me kill the enemy ...");
        }
    }
}

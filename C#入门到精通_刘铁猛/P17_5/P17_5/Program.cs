using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WASPEC.WebsiteURL);
        }
    }

    class WASPEC
    {
        public const string WebsiteURL = "http://www.waspec.org";
        public static readonly Building Location = new Building("Some Address");

    }

    class Building
    {
        public Building(string address)
        {
            this.Address = address;
        }
        public string Address { get; set; }

    }
}

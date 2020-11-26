using P31_7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Combine.Models;

namespace P31_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new EvanDatabaseEntities();
            // var dataTables = dbContext.DateTables.ToList();
            // foreach (var t in dataTables)
            // {
            //     Console.WriteLine(t.DataID);
            // }

            // var dataTables = dbContext.DateTables.Select(t => t.DataID).ToList();
            // foreach (var id in dataTables)
            // {
            //     Console.WriteLine(id);
            // }

            // var dataTables = dbContext.DateTables.Select(t => t.DataID + " " + t.Date).ToList();
            // foreach (var i in dataTables)
            // {
            //     Console.WriteLine(i);
            // }

            var dataTables = dbContext.DateTables.Where(t => t.DataID == 3)
                .Select(t => t.DataID + " " + t.Date).ToList();
            foreach (var i in dataTables)
            {
                Console.WriteLine(i);
            }

            var count = dbContext.DateTables.Count(t => t.DataID == 3);
            Console.WriteLine(count);
        }
    }
}

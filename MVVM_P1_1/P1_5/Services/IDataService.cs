using P1_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_5.Services
{
    interface IDataService
    {
        List<Dish> GetAllDishes();
    }
}

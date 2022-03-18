using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab.Models
{
    public class LoadDate
    {

        public static int num = 5;
        public static List<Car> cars = new List<Car>()
            {
                new Car(){Num = 1, Color="Red", Model="Honda-183", Manfacture="USA"},
                new Car(){Num = 2, Color="Blue", Model="Honda-186", Manfacture="USA"},
                new Car(){Num = 3, Color="Black", Model="Mrecedes", Manfacture="CB"},
                new Car(){Num = 4, Color="White", Model="GKO", Manfacture="USA"},
                new Car(){Num = 5, Color="Red", Model="BMW", Manfacture="German"},
            };

  
    }
}
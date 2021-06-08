using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class MyOwnAutoShop
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan(100m, 100000, "Red", 10);
            Console.WriteLine("Sale price of sedan : " + sedan.GetSalePrice());
            Ford ford1 = new Ford(150m, 150000, "White", 2019, 10);
            Console.WriteLine("Sale price of ford1: " + ford1.GetSalePrice());
            Ford ford2 = new Ford(200m, 175000, "Black", 2020, 5);
            Console.WriteLine("Sale price of ford2: " + ford2.GetSalePrice());
            Truck truck1 = new Truck(120m, 110000, "Blue", 2500);
            Console.WriteLine("Sale price of truck1: " + truck1.GetSalePrice());
            Truck truck2 = new Truck(110m, 95000, "Gray", 1000);
            Console.WriteLine("Sale price of truck2: " + truck2.GetSalePrice());

            Console.ReadKey();
        }
    }
}

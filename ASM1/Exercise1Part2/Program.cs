using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1Part2
{
    class Variables
    {
        static void Main(string[] args)
        {
            int radius = 4;
            const double PI = 3.14159;
            double circum, area;
            area = PI * radius * radius;
            circum = 2 * PI * radius;
            //print result
            Console.WriteLine("Ban kinh = {0}, PI = {1}", radius, PI);
            Console.WriteLine("Dien tich {0}", area);
            Console.WriteLine("Chu vi {0}", circum);
            Console.ReadKey();
            // => Chuong trinh tinh chu vi va dien tich hinh tron
        }
    }
}

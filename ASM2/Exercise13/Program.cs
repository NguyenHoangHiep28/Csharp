using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string fullName;
            int stayDays, meals;
            ulong rent, mealsCost, serveCost, total;
            Console.WriteLine("Enter your name: ");
            fullName = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter stay days (>0): ");
            } while (!int.TryParse(Console.ReadLine(), out stayDays));
            do
            {
                Console.WriteLine("Enter number of meals: ");
            } while (!int.TryParse(Console.ReadLine(), out meals));
            rent = (ulong)stayDays * 500000;
            mealsCost = (ulong)meals * 200000;
            serveCost = (ulong)stayDays * 100000;
            total = rent + mealsCost + serveCost;

            Console.WriteLine("\n************************************************");
            Console.WriteLine("Khách sạn Five Stars\nHóa đơn khách sạn\n");
            Console.WriteLine("Quí Ông(Bà): " + fullName);
            Console.WriteLine("\nSố ngày ở : {0} Số bữa ăn : {1}", stayDays, meals);
            Console.WriteLine("\nTiền ở: {0}VND Tiền ăn : {1}VND Phí phục vụ : {2}VND", rent, mealsCost, serveCost);
            Console.WriteLine("\nTổng cộng : {0}VND", total);
            Console.WriteLine("\nHân hạnh phục vụ quí khách");
            Console.WriteLine("\n************************************************");
            Console.ReadKey();
        }
    }
}

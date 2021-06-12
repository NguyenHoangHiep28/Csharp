using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Exercise12
    {
        static void Main(string[] args)
        {
            
            ulong tiengui, tiennhan;
            double laixuat;
            int thoigiangui;
            do
            {
                Console.WriteLine("Nhap so tien gui (VND): ");
            } while (!ulong.TryParse(Console.ReadLine(), out tiengui));
            while (true)
            {
                do
                {
                    Console.WriteLine("Nhap so tien muon nhan (VND): ");
                } while (!ulong.TryParse(Console.ReadLine(), out tiennhan));
                if (tiennhan <= tiengui)
                {
                    Console.WriteLine($"Tien nhan phai > tien gui (>{tiengui} VND)");
                } else
                {
                    break;
                }
            }
            do
            {
                Console.WriteLine("Nhap so thang gui: ");
            } while (!int.TryParse(Console.ReadLine(), out thoigiangui));
            laixuat =(100 * (tiennhan - tiengui) / (tiengui * (ulong) thoigiangui));
            Console.WriteLine("Lai xuat la {0:F1}%", laixuat);
            Console.ReadKey();
        }
    }
}

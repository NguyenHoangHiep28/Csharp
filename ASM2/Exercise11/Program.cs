using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            ulong tiengui, tiennhan;
            double laixuat;
            double thoigiangui;
            do
            {
                Console.WriteLine("Nhap so tien gui (VND): ");
            } while (!ulong.TryParse(Console.ReadLine(), out tiengui));
            while (true)
            {
                do
                {
                    Console.WriteLine("Nhap lai xuat (%): ");
                } while (!double.TryParse(Console.ReadLine(), out laixuat));
                if (laixuat <= 0)
                {
                    Console.WriteLine("Lai xuat phai > 0");
                }
                else
                {
                    break;
                }
            }
            while (true)
            {
                do
                {
                    Console.WriteLine("Nhap so tien mong muon nhan: ");
                } while (!ulong.TryParse(Console.ReadLine(), out tiennhan));
                if (tiennhan <= tiengui)
                {
                    Console.WriteLine($"So tien nhan phai > tien gui (> {tiengui} VND)");
                }
                else
                {
                    break;
                }
            }
            thoigiangui =(double) (100 * (tiennhan - tiengui) / (tiengui * laixuat));
            Console.WriteLine("Can gui {0:F1} thang de so tien nhan la {1} VND", thoigiangui, tiennhan);
            Console.ReadKey();
        }
    }
}

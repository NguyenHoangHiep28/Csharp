using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Exercise10
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
                    Console.WriteLine("Nhap lai xuat (%): ");
                } while (!double.TryParse(Console.ReadLine(), out laixuat));
                if (laixuat <= 0)
                {
                    Console.WriteLine("Lai xuat phai > 0");
                } else
                {
                    break;
                }
            }
            do
            {
                Console.WriteLine("Nhap so thang gui: ");
            } while (!int.TryParse(Console.ReadLine(), out thoigiangui));
            tiennhan =(ulong)(tiengui + (tiengui / 100 * laixuat * thoigiangui));
            Console.WriteLine($"Sau {thoigiangui} thang, so tien nhan la: {tiennhan} VND");
            Console.ReadKey();
        }
    }
}

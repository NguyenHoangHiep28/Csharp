using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise1
{
    class CongNhan : Person
    {
        private string ngheNghiep;
        private int mucThuNhap;

        public string NgheNghiep { get; set; }
        public int MucThuNhap { get; set; }
        public override void In()
        {
            Console.WriteLine($"{HoTen}\t{NgaySinh:dd-MM-yyyy}\t{QueQuan}\t{NgheNghiep}\t{MucThuNhap}");
        }

        public override Person Nhap()
        {

            Console.WriteLine("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Nhap ngay sinh: ");
                    NgaySinh = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
            Console.WriteLine("Nhap que quan: ");
            QueQuan = Console.ReadLine();
            Console.WriteLine("Nhap nghe nghiep: ");
            NgheNghiep = Console.ReadLine();

            do
            {
                Console.WriteLine("Nhap muc thu nhap: ");
            } while (!int.TryParse(Console.ReadLine(), out mucThuNhap));
            MucThuNhap = mucThuNhap;
            return this;
        }
    }
    }

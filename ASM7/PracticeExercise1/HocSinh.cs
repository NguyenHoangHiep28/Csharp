using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise1
{
    class HocSinh : Person
    {
        private string tenLop;
        private float diemTrungBinh;

        public string TenLop { get; set; }
        public float DiemTrungBinh { get; set; }
        public override void In()
        {
            Console.WriteLine($"{HoTen}\t{NgaySinh:dd-MM-yyyy}\t{QueQuan}\t{TenLop}\t{DiemTrungBinh}");
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
            Console.WriteLine("Nhap ten lop: ");
            TenLop = Console.ReadLine();

            do
            {
                Console.WriteLine("Nhap diem trung binh: ");
            } while (!float.TryParse(Console.ReadLine(), out diemTrungBinh));
            diemTrungBinh = DiemTrungBinh;
            return this;
        }
    }
}

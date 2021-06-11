using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise1
{
    class Test
    {
        static void Main(string[] args)
        {

            Person[] people = new Person[4];
            people[0] = new CongNhan() { HoTen = "Nguyen Van A", NgaySinh = Convert.ToDateTime("1998/08/06"), NgheNghiep = "Cong nhan", QueQuan = "Ha Noi", MucThuNhap = 1000 };
            people[1] = new HocSinh() { HoTen = "Tran Van B", NgaySinh = Convert.ToDateTime("2003/07/04"), QueQuan = "Hai Phong", TenLop = "12A", DiemTrungBinh = 8.9f };
            people[2] = new CongNhan() { HoTen = "Hoang Thi C", NgaySinh = Convert.ToDateTime("1995/04/03"), NgheNghiep = "Giao Vien", QueQuan = "Ha Noi", MucThuNhap = 1200 };
            people[3] = new HocSinh() { HoTen = "Nguyen Van D", NgaySinh = Convert.ToDateTime("2003/11/07"), QueQuan = "Hai Phong", TenLop = "12B", DiemTrungBinh = 5.1f };
            Console.WriteLine("Danh sach cong nhan: ");
            foreach (var person in people)
            {
                if(person is CongNhan)
                {
                    person.In();
                }
            }
            Console.WriteLine("Danh sach hoc sinh: ");
            foreach (var person in people)
            {
                if(person is HocSinh)
                {
                    person.In();
                }
            }

            Console.ReadKey();
        }
    }
}

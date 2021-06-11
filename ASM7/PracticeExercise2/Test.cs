using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise2
{
    class Test
    {
        static void Main(string[] args)
        {
            Hinh hinh1 = new HinhVuong() { Canh = 4.0f};
            Console.WriteLine("Dien tich hinh vuong la : {0:F1}", hinh1.GetArea());
            Hinh hinh2 = new HinhTamGiac() { CanhDay = 5.0f, ChieuCao = 3.0f };
            Console.WriteLine("Dien tich hinh tam giac la: {0:F1}", hinh2.GetArea());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise2
{
    class HinhTamGiac : Hinh
    {
        public float CanhDay { get; set; }
        public float ChieuCao { get; set; }
        public override float GetArea()
        {
            return (CanhDay * ChieuCao) / 2;
        }
    }
}

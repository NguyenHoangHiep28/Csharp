using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise2
{
    class HinhVuong : Hinh
    {
        public float Canh { get; set; }
        public override float GetArea()
        {
            return Canh * Canh;
        }
    }
}

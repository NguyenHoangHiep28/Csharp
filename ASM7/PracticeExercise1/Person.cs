using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise1
{
    abstract class Person
    {
        //fields
        private string hoTen;
        private DateTime ngaySinh;
        private string queQuan;

        //properties
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string QueQuan { get; set; }

        //abstract methods
        public abstract Person Nhap();
        public abstract void In();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Ford : Car
    {
        private int year, manufacturerDiscount;
        public Ford()
        {

        }

        public Ford(decimal speed, double regularPrice, string color,int year, int manufacturerDiscount):base(speed, regularPrice, color)
        {
            this.year = year;
            this.manufacturerDiscount = manufacturerDiscount;
        }
        public override double GetSalePrice()
        {
            return base.GetSalePrice() - manufacturerDiscount;
        }
    }
}

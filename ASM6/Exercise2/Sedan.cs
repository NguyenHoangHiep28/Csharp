using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Sedan:Car
    {
        private int length;
        public Sedan()
        {

        }
        public Sedan(decimal speed, double regularPrice, string color, int length):base(speed, regularPrice, color)
        {
            this.length = length;
        }
        public override double GetSalePrice()
        {
            double discount;
            if(length > 20)
            {
                discount = 5;
            } else
            {
                discount = 10;
            }
            return base.GetSalePrice() - (base.GetSalePrice() / 100 * discount);
        }
    }
}

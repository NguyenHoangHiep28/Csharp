using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Truck : Car
    {
        private int weight;
        public Truck(decimal speed, double regularPrice, string color, int weight):base(speed, regularPrice, color)
        {
            this.weight = weight;
        }
        public override double GetSalePrice()
        {
            double discount;
            if (weight > 2000)
            {
                discount = 10;
            } else
            {
                discount = 20;
            }
            return base.GetSalePrice() - (base.GetSalePrice() / 100 * discount);
        }
    }
}

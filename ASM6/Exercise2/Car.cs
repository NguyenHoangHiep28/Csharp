using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Car
    {
        private decimal speed;
        private double regularPrice;
        private string color;
        public Car()
        {

        }

        public Car(decimal speed, double regularPrice, string color)
        {
            this.speed = speed;
            this.regularPrice = regularPrice;
            this.color = color;
        }
        public virtual double GetSalePrice()
        {
            return regularPrice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
    class LuxuryCar : Car
    {
        public float specialRate = 80 / 100;
        public float SpecialRate
        {
            get { return specialRate; }
            set { specialRate = value; }
        }
        public override float CalculatePrice()
        {
            return RootPrice + CalculateTax() + RootPrice * specialRate;
        }
        public float CalculatePrice(float transportCost)
        {
            return RootPrice + CalculateTax() + RootPrice * specialRate + transportCost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
    class Car : ICar
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Year { get; set; }
        public int Seat { get; set; }
        public float RootPrice { get; set; }
        public virtual float CalculatePrice()
        {
            return RootPrice + CalculateTax();
        }

        public float CalculateTax()
        {
            float tax;
            if (Seat < 7)
            {
                tax = RootPrice * 60 / 100;
            }
            else
            {
                tax = RootPrice * 70 / 100;
            }
            return tax;
        }

        public void GetInfor()
        {
            Console.WriteLine($"{Name} car produced by {Producer} in {Year} has {Seat} seats" +
                $"with the total price is {CalculatePrice():F0}$");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
    class BusCollection
    {
        public Car[] objCar;
        public BusCollection(int length)
        {
            objCar = new Car[length];
        }
        public Car this[int index]
        {
            get { return objCar[index]; }
            set { objCar[index] = value; }
        }
        public void DisplayDetail()
        {
            Console.WriteLine("\nBus Name\t\tBus Producer\t\tYear\t\tSeat\t\tTotal Price\n" +
                              "--------\t\t------------\t\t----\t\t----\t\t-----------");
            foreach (var car in objCar)
            {
                Console.WriteLine($"{car.Name}\t\t\t{car.Producer}\t\t\t{car.Year}\t\t{car.Seat}\t\t{car.CalculatePrice()}");
            }
        }
    }
}

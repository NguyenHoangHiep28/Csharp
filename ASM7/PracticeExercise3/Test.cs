using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise3
{
    class Test
    {
        static void Main(string[] args)
        {
            LuxuryCar myLuxuryCar = new LuxuryCar();
            Console.WriteLine("Enter Name : ");
            myLuxuryCar.Name = Console.ReadLine();
            Console.WriteLine("Enter Producer :");
            myLuxuryCar.Producer = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Enter Year: ");
                    myLuxuryCar.Year = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Enter Seats: ");
                    myLuxuryCar.Seat = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Enter Root Price: ");
                    myLuxuryCar.RootPrice = (float)Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (true);
            myLuxuryCar.GetInfor();
            Console.WriteLine("Total price of Luxury Car: " + myLuxuryCar.CalculatePrice(20000));

            BusCollection busCollection = new BusCollection(1);
            busCollection[0] = myLuxuryCar;
            busCollection.DisplayDetail();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            double r;
            bool confirmContinue = true;
            do
            {

                try
                {
                    Console.WriteLine("Enter radius: ");
                    r = Convert.ToDouble(Console.ReadLine());
                    double area = PI * r * r;
                    double circumference = 2 * PI * r;
                    Console.WriteLine("Area is : {0:F1}", area);
                    Console.WriteLine("Circumferece is: {0:F1}", circumference);
                    Console.WriteLine("Continue?");
                    string confirm = Console.ReadLine();
                    if (confirm.ToUpper().Equals("Y"))
                    {
                        confirmContinue = true;
                    }
                    else
                    {
                        confirmContinue = false;
                        Environment.Exit(0);
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (confirmContinue);


        }
    }
}

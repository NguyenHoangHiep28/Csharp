using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool confirmContinue = true;
            do
            {
                try
                {
                    Console.WriteLine("P(x,y) = 4x^2y - 2xy + 6xy^2 - 13");
                    Console.WriteLine("Enter x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter y: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    double result = 4*x*x*y - 2*x*y + 6*x*y*y - 13;
                    Console.WriteLine($"P({x},{y}) = {result:F1}");
                    Console.WriteLine("Continue?(Y/N)");
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } while (confirmContinue);
            Console.ReadKey();
        }
    }
}

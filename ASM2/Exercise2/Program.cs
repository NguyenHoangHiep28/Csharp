using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            bool confirmContinue = true;
            do
            {
                try
                {
                    Console.WriteLine("Y(x) = 3x^2 + 4x - 7");
                    Console.WriteLine("Enter x for caculating result: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    double result = 3 * x * x + 4 * x - 7;
                    Console.WriteLine($"Y({x}) = {result:F1}");
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

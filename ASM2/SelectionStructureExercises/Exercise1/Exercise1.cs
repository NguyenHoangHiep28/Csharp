using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStructureExercises
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            double delta, a, b, c, x1, x2;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Equation : ax^2 + bx + c");
                do
                {
                    Console.WriteLine("Enter a: ");
                } while (!double.TryParse(Console.ReadLine(), out a));
                do
                {
                    Console.WriteLine("Enter b: ");
                } while (!double.TryParse(Console.ReadLine(), out b));
                do
                {
                    Console.WriteLine("Enter c: ");
                } while (!double.TryParse(Console.ReadLine(), out c));
                delta = b * b - (4 * a * c);
                    if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Equation has 2 roots : x1 = {0:F1} x2 = {1:F1}", x1, x2);
                }
                else if (delta < 0)
                {
                    Console.WriteLine("Equation has no root!");
                }
                else
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("Equation has a double root: x1 = x2 = {0:F1}", x1);
                }
                Console.WriteLine("Continue ? (Y / N)");
                string confirmContinue = Console.ReadLine();
                if (!confirmContinue.ToUpper().Equals("Y"))
                {
                    loop = false;
                }
            }
            Console.WriteLine("\nProgram ended!");
            Console.ReadKey();
        }
    }
}

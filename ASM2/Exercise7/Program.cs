using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool confirmContinue = true;
            do
            {
                try
                {
                    Console.WriteLine("ax + b = 0");
                    Console.WriteLine("Enter a: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter b: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        Console.WriteLine("Equation: x + {0} = 0", b);
                    }
                    else
                    {
                        Console.WriteLine("Equation: {0}x + {1} = 0", a, b);
                    }
                    Console.WriteLine("Continue?");
                    string confirm = Console.ReadLine();
                    if (confirm.ToUpper().Equals("Y"))
                    {
                        confirmContinue = true;
                    } else
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
        }
    }
}

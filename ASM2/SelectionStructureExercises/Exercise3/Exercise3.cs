using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Exercise3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Calculator Program =====");
            int choice;
            double a, b, x;
            do
            {
                Console.WriteLine("\n");
                DisplayMenu();
                do
                {
                    Console.WriteLine("Enter your choice: ");
                } while (!int.TryParse(Console.ReadLine(), out choice));
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("\nPROGRAM ENDED!");
                        break;
                    case 1:
                        Console.WriteLine("Enter number 1: ");
                        a = InputNumber();
                        Console.WriteLine("Enter number 2:");
                        b = InputNumber();
                        Console.WriteLine("{0:F1} + {1:F1} = {2:F1}", a, b, a + b);
                        break;
                    case 2:
                        Console.WriteLine("Enter subtrahend (so bi tru): ");
                        a = InputNumber();
                        Console.WriteLine("Enter minus number: ");
                        b = InputNumber();
                        Console.WriteLine("{0:F1} - {1:F1} = {2:F1}", a, b, a - b);
                        break;
                    case 3:
                        Console.WriteLine("Enter number 1: ");
                        a = InputNumber();
                        Console.WriteLine("Enter number 2:");
                        b = InputNumber();
                        Console.WriteLine("{0:F1} * {1:F1} = {2:F1}", a, b, a * b);
                        break;
                    case 4:
                        Console.WriteLine("Enter dividend (so bi chia): ");
                        a = InputNumber();
                        Console.WriteLine("Enter divisor (so chia): ");
                        b = InputNumber();
                        if (b == 0.0)
                        {
                            Console.WriteLine("Divisor must != 0");
                        }
                        else
                        {
                            Console.WriteLine("{0:F1} * {1:F1} = {2:F1}", a, b, a / b);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Enter a number: ");
                        x = InputNumber();
                        Console.WriteLine("Square root of {0:F1} is: {1:F1}", x, Math.Sqrt(x));
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice != 0);
            Console.ReadKey();
        }
        static void DisplayMenu()
        {
            Console.WriteLine("MENU:");
            Console.WriteLine("1. PLUS 2 numbers");
            Console.WriteLine("2. MINUS 2 numbers");
            Console.WriteLine("3. MULTiPLY 2 numbers");
            Console.WriteLine("4. DIVIDE 2 numbers");
            Console.WriteLine("5. CACULATE SQUARE ROOT of a number");
            Console.WriteLine("0. EXIT");
        }
        static double InputNumber()
        {
            double number;
            while (true)
            {
                try
                {
                    number = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return number;
        }
    }
}

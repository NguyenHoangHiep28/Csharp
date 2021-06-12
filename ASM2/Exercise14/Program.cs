using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    class Exercise14
    {
        static void Main(string[] args)
        {
            
            int number;
            while (true)
            {
                do
                {
                    Console.WriteLine("Enter an integer : (>0)");
                } while (!int.TryParse(Console.ReadLine(), out number));
                if(number < 0)
                {
                    Console.WriteLine("The number must > 0 for calculating square root and being divided by!");
                } else
                {
                    break;
                }
            }
            Console.WriteLine("N\t|N*N\t|1/N\t|Square Root\t|Forth Root");
            for (int i = number; i <= number + 5; i++)
            {
                Console.WriteLine("{0}\t {1}\t {2:F1}\t {3:F1}\t\t {4:F1}", i, i*i,(float) 1/i, Math.Sqrt(i), Math.Pow(i, 1.0/4));
            }
            Console.ReadKey();

        }
    }
}

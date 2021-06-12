using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16
{
    class Exercise16
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of cans for purchasing: ");
                    int cans = Convert.ToInt32(Console.ReadLine());
                    if (cans > 0)
                    {
                        int pens = cans % 3;
                        int hats = (cans - pens) / 3;
                        const ulong price = 27000;
                        Console.WriteLine("Total Pay: {0} VND",(ulong) cans * price);
                        Console.WriteLine("Your gift includes: {0} hat(s), {1} pen(s) ", hats, pens);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Quantity of cans must greater than 0!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            double oldConsumption, newConsumption;
            bool confirmContinue = true;
            do
            {
                try
                {

                    Console.WriteLine("Please enter your name :");
                    string fullName = Console.ReadLine();
                    Console.WriteLine("Please enter your old electricity consumption: ");
                    oldConsumption = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter your new electricity consumption: ");
                    newConsumption = Convert.ToDouble(Console.ReadLine());
                    double consumption = newConsumption - oldConsumption;
                    Console.WriteLine("===== Electricity Bill =====");
                    Console.WriteLine($"Customer : {fullName}");
                    Console.WriteLine($"Old amount of consumption: {oldConsumption}");
                    Console.WriteLine($"New amount of consumption: {newConsumption}");
                    Console.WriteLine("Consumption: {0:F1}", consumption);
                    Console.WriteLine("Total pay: {0:F1} VND", consumption * 452.45);
                    Console.WriteLine("Please use electricity more economically to protect the environment!");
                    Console.WriteLine("Continue? (Y/N)");
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

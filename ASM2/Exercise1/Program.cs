using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpExercises
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            string fullName;
            bool confirmContinue = true;
            while (confirmContinue)
            {
                try
                {
                    Console.WriteLine("Enter your name: ");
                    fullName = Console.ReadLine();
                    Console.WriteLine("Enter your year of birth: ");
                    var year = Console.ReadLine();
                    
                    if (int.Parse(year) > 2021)
                    {
                        Console.WriteLine($"Year of birth must <= {DateTime.Now.Year}");
                    } else
                    {
                        int age = DateTime.Now.Year - int.Parse(year);
                        Console.WriteLine($"Name: {fullName}");
                        Console.WriteLine($"Year of Birth: {year}");
                        Console.WriteLine($"Age: {age}");
                        Console.WriteLine($"Age in 2010: {2010 - int.Parse(year)}");
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
                   
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}

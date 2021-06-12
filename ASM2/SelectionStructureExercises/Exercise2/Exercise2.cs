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
            while (true)
            {
                Console.WriteLine("Enter your fullname: ");
                string fullName = Console.ReadLine();
                string[] wordsOfName = fullName.Split(' ');
                bool isFemale = false;
                for (int i = 0; i < wordsOfName.Length; i++)
                {
                    if (wordsOfName[i].ToUpper().Equals("THI"))
                    {
                        isFemale = true;
                        break;
                    }
                }
                if (isFemale)
                {
                    Console.WriteLine("You are female!");
                }
                else
                {
                    Console.WriteLine("You are male!");
                }
                Console.WriteLine("Continue? (Y/N)");
                string confirmContinue = Console.ReadLine();
                if (!confirmContinue.ToUpper().Equals("Y"))
                {
                    break;
                }
            }
            Console.WriteLine("\nProgram ended!");
            Console.ReadKey();
        }
    }
}

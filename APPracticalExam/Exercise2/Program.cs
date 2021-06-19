using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string searchString = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            string searchWord = Console.ReadLine();
            int foundIndex, startFindIndex = 0, foundTimes = 0;
            do
            {
                foundIndex = searchString.Trim().IndexOf(searchWord, startFindIndex);
                if (foundIndex > -1)
                {
                    foundTimes++;
                }
                startFindIndex = foundIndex + 1;

            } while (foundIndex > -1);
            Console.WriteLine("Word found {0} time(s) in the string", foundTimes);

            Console.ReadKey();
        }
    }
}

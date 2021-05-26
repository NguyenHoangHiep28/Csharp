using System;

namespace Exercise3Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            for (x = 0; x < 10; x++, Console.Write("\n")) ;
            for (y = 0; y < 10; y++, Console.WriteLine("{0}", y)) ;
            Console.ReadKey();
        }
    }
}

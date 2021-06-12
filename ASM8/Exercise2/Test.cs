using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Test
    {
        static void Main(string[] args)
        {
            Novel novel = new Novel(2);
            novel[0] = new Book("100 - 123 - 456", "Harry Potter", 101);
            novel[1] = new Book("110 - 133 - 567", "Sherlock Holmes", 201);
            Console.WriteLine("CATEGORY: NOVEL");
            novel.DisplayInfor();

            Console.ReadKey();
        }
    }
}

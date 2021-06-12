using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Exercise9
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Enter sender surname: ");
            string sSurname = Console.ReadLine();
            Console.WriteLine("Enter sender first name: ");
            string sFirstName = Console.ReadLine();
            Console.WriteLine("Enter receiver surname: ");
            string rSurname = Console.ReadLine();
            Console.WriteLine("Enter receiver first name: ");
            string rFirstName = Console.ReadLine();
            Console.WriteLine($"Thân gửi {rSurname} {rFirstName}\nNhân dịp sinh nhật " +
                $"của {rFirstName}, cho phép {sFirstName} gửi đến {rFirstName} Những lời " +
                "chúc tốt đẹp nhất về sức khỏe, hạnh phúc và thành công trong mọi lĩnh vực." +
                $"Gửi lời thăm sức khỏe hai bác của {rFirstName}" +
                $"\nBạn của {rFirstName}\n{sSurname} {sFirstName}" + 
                $"\nTB: Ba má {sFirstName} Thường nhắc đến {rFirstName}");
            Console.ReadKey();
        }
    }
}

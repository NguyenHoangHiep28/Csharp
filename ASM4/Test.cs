using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4
{
    class Test
    {
        static void Main(string[] args)
        {
            Window[] windows = new Window[3];
            windows[0] = new ListBox(50, 100, "Content of list box 1");
            windows[1] = new ListBox(200, 100, "Content of list box 2");
            windows[2] = new Button(30, 50);

            for (int i = 0; i < 3; i++)
            {
                windows[i].DrawWindow();
            }
            Console.ReadKey();
        }
    }
}

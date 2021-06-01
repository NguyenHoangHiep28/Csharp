using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4
{
    class ListBox : Window
    {
        private string mListContents;

        public ListBox(int top, int left, string thecontent): base(top, left)
        {
            mListContents = thecontent;
        }
        public override void DrawWindow()
        {
            Console.WriteLine("Writing string to the listbox: " + mListContents);
        }
    }
}

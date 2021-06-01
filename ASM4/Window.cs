using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM4
{
    abstract class Window
    {
        protected int top, left;

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        public int Top
        {
            get;set;
        }
        public int Left
        {
            get; set;
        }

        public abstract void DrawWindow();
    }
}

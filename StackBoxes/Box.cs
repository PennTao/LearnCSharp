using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBoxes
{
    class Box
    {
        public Box(int w, int d, int h)
        {
            Height = h;
            Width = w;
            Depth = d;
        }
        public int Height { set; get; }
        public int Width { set; get; }
        public int Depth { set; get; }
        public bool IsLarger(Box b)
        {
            if(this.Depth > b.Depth && this.Width > b.Width && this.Height > b.Height)
                return true;
            else 
                return false;

        }
    }
}

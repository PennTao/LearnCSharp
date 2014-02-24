using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannoi
{
    class Tower
    {
        public Tower(int i)
        {
            Index = i;
            towers = new Stack<int>();
        }
        public int Index { get; set; }
        public Stack<int> towers;
        public void add(int i)
        {
            towers.Push(i);
        }
        public void MoveTower(int n, Tower buf, Tower dest)
        {
            if(n > 0)
            {
                MoveTower(n - 1, dest, buf);
                MoveTop(dest);
                buf.MoveTower(n - 1, this, dest);

            }
        }
        public void MoveTop(Tower dest)
        {
            int top = this.towers.Pop();
            Console.WriteLine("Move disk  {0} from {1} to {2}", top, this.Index, dest.Index);
            dest.towers.Push(top);
        }
    }
}

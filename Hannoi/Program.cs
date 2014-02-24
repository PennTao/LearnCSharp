using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hannoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tower orig = new Tower(0);
            Tower buf = new Tower(1);
            Tower dest = new Tower(2);
            int n = 3;
            for (int i = n - 1; i >= 0; i--)
            {
                orig.add(i);
            }
            orig.MoveTower(n, buf, dest);
        }


    }
}

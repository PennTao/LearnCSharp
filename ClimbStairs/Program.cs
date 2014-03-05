using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*A child can climb 1 ,2 or 3 steps at a time, given the number of stairs, return the number of all possible ways 
 to climb the stairs*/
namespace ClimbStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStairs = 4;
            Console.WriteLine(Climb(numStairs));

        }

        static int Climb(int numStairs)
        {
            if (numStairs <= 0)
                return 0;
            if (numStairs == 1)
                return 1;
            if (numStairs == 2)
                return 2;
            if (numStairs == 3)
                return 4;
            return Climb(numStairs - 1) + Climb(numStairs - 2) + Climb(numStairs - 3);
        }
    }

	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*imagin a robo sitting on the upper left corner of an X by Y grid. The robot can only move down or right.
 How many possible paths are there for the robot go from(0,0) to (X-1,Y-1)?*/
namespace GridTotalPath
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 3;
            int Y = 4;
            Console.WriteLine("total num of path from 0,0 to {0},{1} is {2}",X-1,Y-1, GetTotalNumPath(X,Y));
        }
        static int GetTotalNumPath(int X, int Y)
        {
            
            if (X < 1 || Y < 1)
                return 0;
            int[,] grid = new int[X, Y];
            grid[0, 0] = 0;
            for (int i = 1; i < X; i++)
                grid[i, 0] = 1;
            for (int i = 1; i < Y; i++)
                grid[0, i] = 1;
            for (int i = 1; i < X; i++)
            {
                for (int j = 1; j < Y; j++)
                {
                    grid[i, j] = grid[i, j - 1] + grid[i - 1, j];
                }
            }
          //  Console.WriteLine(grid[X - 1, Y - 1]);

            return grid[X - 1, Y - 1];
        }
    }
}

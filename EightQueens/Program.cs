
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Solve Eight Queens problem*/
namespace EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] board = {9,9,9,9,9,9,9,9,9};
            LinkedList<int[]> res = new LinkedList<int[]>();
            PlaceQueen(0, ref res, board);
            Console.WriteLine("{0} eight queens solution:", res.Count);
            foreach (int[] sol in res)
            {
                Display(sol);
            }
        }
        static void PlaceQueen(int row, ref LinkedList<int[]> res, int[] col)
        {
            if (row > 7)
            {
                res.AddLast((int[])col.Clone());
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    col[row] = i;
                    if (IsBoardValid(row, col))
                    {
                        PlaceQueen(row + 1, ref res, col);
                    }

                }
            }
   

        }
        static bool IsBoardValid(int row, int[] col)
        {
            for (int i = 0; i < row; i++)
            {
                if (col[i] == col[row])
                    return false;
                if (Math.Abs(col[row] - col[i]) == row - i)
                    return false;
            }
                return true;
        }
        static void Display(int[] board)
        {
            for (int i = 0; i < 8; i++)
            {
               
               Console.Write("{0} ", board[i]);

               
            }
            Console.WriteLine();
        }
    }
}

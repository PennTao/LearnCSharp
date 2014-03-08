using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Implement Fill funtion in Paint*/
namespace PaintFill
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] canvas = new int[4,4];
        }
        static void Fill(ref int[,] canvas, int oColor, int dColor, int x, int y)
        {
            if (x < 0 || x > canvas.GetLength(0) ||y < 0 || y > canvas.GetLength(1))
            {
                return;
            }
            if(canvas[x,y] == oColor) 
            {
                canvas[x, y] = dColor;
                Fill(ref canvas, oColor, dColor, x - 1, y);
                Fill(ref canvas, oColor, dColor, x+1 , y);
                Fill(ref canvas, oColor, dColor, x , y - 1);
                Fill(ref canvas, oColor, dColor, x, y + 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.10 Given a bunch of boxes, with width w, depth d and height h. One box can only be put on top of 
 another if its w, d and h are strictly larger. develop an algorithm to find the highest stack possible where the 
 height of stack is the sum of all height of boxes*/
namespace StackBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            Box[] boxes = new Box[7];
            boxes[0] = new Box(80, 60, 40);
            boxes[1] = new Box(40, 50, 50);
            boxes[2] = new Box(75, 20, 55);
            boxes[3] = new Box(77, 89, 60);
            boxes[4] = new Box(50, 99, 75);
            boxes[5] = new Box(121, 55, 30);
            boxes[6] = new Box(66, 45, 45);
            LinkedList<Box> maxstack = new LinkedList<Box>();
            int maxheight = 0;
            foreach (Box b in boxes)
            {
                LinkedList<Box> res = new LinkedList<Box>();
                res = BuildHighestStack(boxes, b);
                int curheight = GetHeight(res);
                if (curheight > maxheight)
                {
                    maxheight = curheight;
                    maxstack = new LinkedList<Box>(res);
                }
              
            }
            Console.WriteLine("Max Height:  {0}", maxheight);
            foreach (Box b in maxstack)
            {
                Console.WriteLine("{0}  {1} {2}", b.Width, b.Depth, b.Height);
            }

            
        }
        static LinkedList<Box> BuildHighestStack(Box[] boxes, Box bottom)
        {
            LinkedList<Box> maxstack = new LinkedList<Box>();
            int maxheight = 0;
            foreach (Box b in boxes)
            {
                if (bottom.IsLarger(b))
                {
                    LinkedList<Box> curstack = BuildHighestStack(boxes, b);
                    if (GetHeight(curstack) > maxheight)
                    {
                        maxstack = curstack;
                        maxheight = GetHeight(curstack);
                    }
                }
            }
            maxstack.AddLast(bottom);
            return maxstack;
 
        }
        static int GetHeight(LinkedList<Box> boxstack)
        {
            int totalheight = 0;
            foreach (Box b in boxstack)
            {
                totalheight += b.Height;
            }
            return totalheight;
        }
    }
}

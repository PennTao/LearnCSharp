using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAStackAscending
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stk = new Stack<int>();
            stk.Push(1);
            stk.Push(12);
            stk.Push(6);
            stk.Push(8);
            stk.Push(7);
           
            stk = Sort(stk);
            Console.WriteLine("Sorted Stack in ascendin order:");
            while (stk.Count > 0)
            {
                Console.WriteLine(stk.Pop());
            }

            Console.ReadLine();
        }

        static Stack<int> Sort(Stack<int> stk)
        {
            Stack<int> buf = new Stack<int>();
            if (stk == null)
                return null;
            if (stk.Count == 0)
                return buf;
            buf.Push(stk.Pop());
            while (stk.Count > 0)
            {
                int temp = stk.Pop();
                int count = 0;
                while (buf.Count > 0 && temp < buf.Peek())
                {
                    stk.Push(buf.Pop());
                    count++;
                }
                buf.Push(temp);
                for (uint i = 0; i < count; i++)
                {
                    buf.Push(stk.Pop());
                }
            }
            return buf;


        }
    }
}

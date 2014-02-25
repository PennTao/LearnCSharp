using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();
            for(int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }
            while (queue.size() > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}

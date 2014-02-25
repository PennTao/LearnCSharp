using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    class MyQueue<T>
    {
        private Stack<T> stk1;
        private Stack<T> stk2;

        public MyQueue()
        {
            stk1 = new Stack<T>();
            stk2 = new Stack<T>();
        }

        public void Enqueue(T val)
        {
            stk1.Push(val);
        }
        public T Dequeue()
        {
            T result;
            while (stk1.Count > 0)
            {
                stk2.Push(stk1.Pop());
            }
            result = stk2.Pop();
            while (stk2.Count > 0)
            {
                stk1.Push(stk2.Pop());
            }
                return result;
        }
        public int size()
        {
            return stk1.Count;
        }
    }
}

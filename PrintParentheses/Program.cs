using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int num = 0;
            char[] s = new char[6];
            LinkedList<string> res = new LinkedList<string>();
            GetValidParenthese(n, n, num, ref s, ref res);
            foreach (string str in res)
            {
                Console.WriteLine(str);
 
            }
        }
        static void GetValidParenthese(int left, int right, int num, ref char[] s,ref LinkedList<string> res)
        {
            if (left <0 || right < left)
                return ;
            if (left == 0 && right == 0)
            {
                string str = new string(s);
                res.AddLast(str);
            }
            if (left > 0)
            {
                s[num] = '(';
                GetValidParenthese(left - 1, right, num + 1, ref s, ref res);
            }
            if (right > left)
            {
                s[num] = ')';
                GetValidParenthese(left, right - 1, num + 1, ref s, ref res);
            }
        }
    }
}

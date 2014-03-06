using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStrPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "abc";
            LinkedList<string> res = new LinkedList<string>();
            res = GetAllPermutation(A);
            Console.WriteLine("The permutations of {0} are:", A);
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }
 
        }
        static LinkedList<string> GetAllPermutation(string A)
        {
            LinkedList<string> res = new LinkedList<string>();
            LinkedList<string> resfinal = new LinkedList<string>();
            GetAllPermutationHelper(A, ref res);
            foreach (string s in res)
            {
                if (s.Length == A.Length)
                    resfinal.AddLast(s);
            }
            return resfinal;
        }
        static void GetAllPermutationHelper(string A, ref LinkedList<string> res)
        {
            if (A.Length == 0)
            {
                string empty = "";
                res.AddLast(empty);
                return ;
            }
            else
            {
                char curChar = A[A.Length - 1];
                A = A.Remove(A.Length - 1);
                GetAllPermutationHelper(A,ref res);
                int curSize = res.Count;
                for (int i = 0; i < curSize; i++)
                {
                    string curStr;
                    for (int j = 0; j < res.ElementAt(i).Length; j++)
                    {
                        curStr = res.ElementAt(i);
                        res.AddLast(curStr.Insert(j, curChar.ToString()));
                    }
                    curStr = res.ElementAt(i);
                    res.AddLast(curStr + curChar);
                    
 
                }
 
            }

        }
    }
}

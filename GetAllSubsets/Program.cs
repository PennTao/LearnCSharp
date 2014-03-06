using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllSubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<LinkedList<int>> res = new LinkedList<LinkedList<int>>();
            LinkedList<int> A = new LinkedList<int>();
            for (int i = 1; i < 4; i++)
                A.AddLast(i);
            Console.WriteLine("The set:");
            foreach (int i in A)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("All subsets");
            GetAll(A, ref res);

            for (int i = 0; i < res.Count; i++)
            {
                for (int j = 0; j < res.ElementAt(i).Count; j++)
                {
                    Console.Write(res.ElementAt(i).ElementAt(j));
                    
                }
                Console.WriteLine(";");
            }
        }
        static void GetAll(LinkedList<int> A, ref LinkedList<LinkedList<int>> res) 
        {
            if (A.Count == 0)
            {
                res.AddFirst(new LinkedList<int>());
            }
            else
            {
                int curItem = A.ElementAt(0);
                
                A.RemoveFirst();
                GetAll(A, ref res);
                int curSize = res.Count;
                for (int i = 0; i < curSize; i++ )
                {
                    LinkedList<int> curList = new LinkedList<int>(res.ElementAt(i));
                    curList.AddLast(curItem);
                    res.AddLast(curList);
                }
            }
 
        }
    }
}

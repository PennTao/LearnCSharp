using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*A magic index in a array A[0..n-1] is defined to be an index such that A[i] = i. Given a
 sorted array with distinct integers, write a method to find a magic index, if there is one, in A*/
namespace MagicIndex
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A;
            int min = -50;
            int max = 50;
            int num = 35;
            A = GenRandomArr(min, max, num);
            Array.Sort(A);
            Console.WriteLine("Random array A:");
            foreach (int i in A)
                Console.Write("{0} ", i);
            Console.WriteLine();
            if (GetMagicIndex(A, 0, num - 1) == -1)
            {
                Console.WriteLine("no magic idx in A");
            }
            else
            {
                Console.WriteLine("Magic index is {0}", GetMagicIndex(A, 0, num - 1));
            }
            int[] B = { -2, -1, 2, 12, 19 };
            Console.WriteLine("Array B:");
            foreach (int i in B)
                Console.Write("{0} ", i);
            Console.WriteLine();

            Console.WriteLine("Magic index is {0}", GetMagicIndex(B, 0, 4));


        }

        static int GetMagicIndex(int[] A,int begin, int end)
        {
            if (begin > end)
                return -1;
            int mid = (begin + end) / 2;
            if(A[mid] == mid)
                return mid;
            else if (A[mid] > mid)
            {
                return GetMagicIndex(A, begin, mid - 1);
            }
            else 
            {
                return GetMagicIndex(A, mid + 1, end);
            }
        }
        static int[] GenRandomArr(int min, int max, int num)
        {
            int[] res = new int[num];
            Random randNum = new Random();

            for (int i = 0; i < num; i++)
            {
                int curRand = randNum.Next(min, max);
                while(Array.IndexOf(res,curRand) != -1 )
                    curRand = randNum.Next(min, max);
                res[i] = curRand;
            }
                return res;
        }
    }
}

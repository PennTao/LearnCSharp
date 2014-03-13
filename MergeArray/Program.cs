using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.1  You are given 2 sorted arrays, A and B, where A has a large enough buffer at the end to hold B.
 Write a method to merge B into A in sorted order*/
namespace MergeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Program merge = new Program();
            int[] A = new int[100];
            int[] B = new int[30];
            int[] C = new int[100];
            int lenA = 40;
            int lenB = 30;
            for (int i = 0; i < lenA; i++)
            {
                A[i] = rnd.Next(0, 200);
                C[i] = A[i];
            }
            for (int i = 0; i < lenB; i++)
            {
                B[i] = rnd.Next(0, 200);
                C[i + lenA] = B[i];
            }
            Array.Sort(A,0,lenA);
            Array.Sort(B);
            Array.Sort(C,0,lenA+lenB);

            merge.Merge(A, lenA - 1, B, lenB - 1);
            for (int i = 0; i < lenA+lenB; i++)
            {
                Console.Write("{0} ", A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < lenA+lenB; i++)
            {
                Console.Write("{0} ", C[i]);
            }
        }

        public void Merge(int[] A, int lenA, int[] B, int lenB)
        {
            while (lenB >= 0)
            {
                if (lenA >= 0)
                {
                    if (A[lenA] >= B[lenB])
                    { 
                        A[lenA + lenB + 1] = A[lenA];
                        lenA--;
                    }
                    else
                    {
                        A[lenA + lenB + 1] = B[lenB];
                        lenB--;
                    }
                }
                else 
                {
                    A[lenB] = B[lenB];
                    lenB--;
                }
            }
 
        }
    }
}

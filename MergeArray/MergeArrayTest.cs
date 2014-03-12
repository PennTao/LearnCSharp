using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MergeArray
{
    [TestFixture]
    class MergeArrayTest
    {
        [Test]
        public void TestMerge()
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
            Array.Sort(A, 0, lenA);
            Array.Sort(B);
            Array.Sort(C, 0, lenA + lenB);

            merge.Merge(A, lenA - 1, B, lenB - 1);
            for (int i = 0; i < lenA + lenB - 1; i++)
            {
                Assert.AreEqual(A[i], C[i]);
            }
            Array.Clear(A,0,lenA);
            Array.Clear(B,0,lenB);
            Array.Clear(C,0,lenA+lenB);

            lenA = 3;
            lenB = 3;
            for (int i = 0; i < lenA;i++ )
            {
                A[i] = i * 10;
                B[i] = i;
                C[i] = i;
                C[i + lenA] = i * 10;
            }
            Array.Sort(C,0,lenA+lenB);
            merge.Merge(A,lenA-1,B,lenB-1);
            for(int i =0; i < lenB+lenA-1;i++)
            {
                Assert.AreEqual(A[i],C[i]);
            }
        }
    }
}

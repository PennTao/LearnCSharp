using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Problem 9.8 Y ou have unlimited number of pennies, nickels, dimes and quarters, find all possible ways to get N cents*/
namespace RepresentNCents
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int[]> res = new LinkedList<int[]>();
            int n = 25;
            SumNCents(n, ref res, 0, 0, 0, 0);
            Console.WriteLine("{0} ways to get {1} cents",res.Count, n);
            Console.WriteLine("penny    nickel  dime    quarter");
            foreach(int[] i in res)
            {
                foreach(int j in i)
                {
                    Console.Write("{0}  ",j);
                }
                Console.WriteLine();
            }
        }
        static void SumNCents(int n, ref LinkedList<int[]> res, int penny, int nickel, int dime, int quarter)
        {
            if(n < 0)
                return;
            
            if (n == 0)
            {
                if (res.Count == 0)
                {
                    int[] comb = { penny, nickel, dime, quarter };
                    res.AddLast(comb);
                }
                else
                {
                    int resCount = res.Count;
                    bool bAdd = true;
                    for (int i = 0; i < resCount; i++)
                    {
                        if (res.ElementAt(i)[0] == penny && res.ElementAt(i)[1] == nickel && res.ElementAt(i)[2] == dime && res.ElementAt(i)[3] == quarter)
                        {
                            bAdd = false;
                            break;
                        }
                    }
                    if (bAdd)
                    {
                        int[] comb = { penny, nickel, dime, quarter };

                        res.AddLast(comb);
                    }

                }
                
            }
            else
            {
                SumNCents(n - 1, ref res, penny +1,nickel,dime,quarter);
                SumNCents(n - 5, ref res, penny, nickel+1, dime, quarter);
                SumNCents(n - 10, ref res, penny, nickel, dime+1, quarter);
                SumNCents(n - 25, ref res, penny, nickel, dime, quarter+1);
            }
        }
    }
}

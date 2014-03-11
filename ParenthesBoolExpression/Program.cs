using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*9.11 Given  a bool expression onsisting of the symbols 0, 1, &, |, and ^ and a desired boolean result 
 value result, implement a  funtion to count the number of ways of parenthesizing the expression such that it evaluates
 to result*/
namespace ParenthesBoolExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "0^1|0&1&0";
            Console.WriteLine("{0}", GetAllEvaluation(0, str.Length - 1, true, str));
        }

        static int GetAllEvaluation(int s, int e, bool result, string str)
        {
            if (s == e)
            {
                if ((str[s] == '1' && result) || (str[s] == '0' && !result))
                    return 1;
                else return 0;
            }
            int c = 0;
            if (result)
            {
                for (int i = s + 1; i <= e; i = i + 2)
                {
                    if (str[i] == '|')
                    {
                        c += GetAllEvaluation(s, i - 1, true, str) * GetAllEvaluation(i + 1, e, true, str) +
                            GetAllEvaluation(s, i - 1, true, str) * GetAllEvaluation(i + 1, e, false, str) +
                            GetAllEvaluation(s, i - 1, false, str) * GetAllEvaluation(i + 1, e, true, str);
                    }
                    else if (str[i] == '&')
                    {
                        c += GetAllEvaluation(s, i - 1, true, str) * GetAllEvaluation(i + 1, e, true, str);
                    }
                    else if (str[i] == '^')
                    {
                        c += GetAllEvaluation(s, i - 1, true, str) * GetAllEvaluation(i + 1, e, false, str) +
                            GetAllEvaluation(s, i - 1, false, str) * GetAllEvaluation(i + 1, e, true, str);
                    }
                }
            }
            else
            {
                for (int i = s + 1; i <= e; i = i + 2)
                {
                    if (str[i] == '&')
                    {
                        c += GetAllEvaluation(s, i - 1, false, str) * GetAllEvaluation(i + 1, e, false, str) +
                            GetAllEvaluation(s, i - 1, false, str) * GetAllEvaluation(i + 1, e, true, str) +
                            GetAllEvaluation(s, i - 1, true, str) * GetAllEvaluation(i + 1, e, false, str);
                    }
                    else if (str[i] == '|')
                    {
                        c += GetAllEvaluation(s, i - 1, false, str) * GetAllEvaluation(i + 1, e, false, str);
                    }
                    else if (str[i] == '^')
                    {
                        c += GetAllEvaluation(s, i - 1, false, str) * GetAllEvaluation(i + 1, e, false, str) +
                            GetAllEvaluation(s, i - 1, true, str) * GetAllEvaluation(i + 1, e, true, str);
                    }
                }
            }
            return c;
            
 

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*11.2 Write a method to sort an array of strings so that all the anagrams 
 are next to each other*/
namespace SortAnagramStringList
{
    class Program
    {
        static void Main(string[] args)
        {
     
        }

        public static List<string> SortAnaStrList(List<string> list)
        {
            if (list.Count == 0)
                return list;
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>(); ;
            foreach (string str in list)
            {
                string keyStr = String.Concat(str.OrderBy(c => c));
                if (!map.ContainsKey(keyStr))
                {
                    List<string> val = new List<string>();
                    val.Add(str);
                    map[keyStr] = val;
                }
                else 
                {
                    map[keyStr].Add(str);
                } 
            }
            List<string> res = new List<string>();
            foreach (string key in map.Keys)
            {
                res.AddRange(map[key]);
            }
            return res;
        }
    }
}

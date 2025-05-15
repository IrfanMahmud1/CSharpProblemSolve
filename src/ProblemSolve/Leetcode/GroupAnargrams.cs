using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class GroupAnargrams
    {
        private static string Hashing(string str)
        {
            var arr = new int[27];
            foreach (var ch in str)
            {
                arr[(ch - 'a') + 1]++;
            }
            return string.Join(",", arr);
        }
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var ans = new List<IList<string>>();
            var map = new Dictionary<string, int>();
            var index = map.Count;
            foreach (var str in strs)
            {
                var hash = Hashing(str);
                if (!map.ContainsKey(hash))
                {
                    map[hash] = index++;
                    ans.Add(new List<string>());
                }
                ans[map[hash]].Add(str);
            }
            return ans;
        }
    }
}

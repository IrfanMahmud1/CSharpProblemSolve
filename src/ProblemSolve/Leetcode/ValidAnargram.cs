using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExamples
{
    public class ValidAnargram
    {
        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }
            var freq = new int[27];
            var len = s.Length;
            for (int i = 0; i < len; i++)
            {
                freq[s[i] - 'a']++;
                freq[t[i] - 'a']--;
            }
            return !freq.Any(x => x != 0);
        }
    }
}

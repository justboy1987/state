using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class LongestWordinDictionarythroughDeleting
    {
        /*
         
            Input:
s = "abpcplea", d = ["ale","apple","monkey","plea"]

Output: 
"apple"
Example 2:
Input:
s = "abpcplea", d = ["a","b","c"]

Output: 
"a"
    */
        public string FindLongestWord(string s, IList<string> d)
        {
            string longest = "";
            for(var i = 0 ; i < d.Count ;i++)
            {
                if (IsSubsequence( d[i],s))
                {
                    if (d[i].Length > longest.Length || (d[i].Length ==longest.Length 
                        && d[i].CompareTo(longest) > 0 ))
                    {
                        longest = d[i];
                    }
                }
            }
            
            return longest;
        }

        bool IsSubsequence(string w, string s)
        {
            char[] wc = w.ToCharArray();
            char[] sc = s.ToCharArray();
            int i = 0, j = 0;
            while (i < wc.Length && j < sc.Length)
            {
                if (wc[i] == sc[j]) i++;
                j++;
            }
            return i == wc.Length;
        }
    }
}

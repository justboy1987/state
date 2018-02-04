using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings
{
    class Implement_strStr
    {
        public int StrStr(string haystack, string needle)
        {
            int m = haystack.Length;
            int n = needle.Length;
            if (n == 0) return 0;
            var lps = MakeNext(needle.ToCharArray());
            for (int i = 0, j = 0; i < m;)
            {
                if (haystack[i] == needle[j])
                {
                    i++;
                    j++;
                }
                if (j == n) return i - j;
                if (i < m && haystack[i] != needle[j])
                {
                    if (j !=0) j = lps[j - 1];
                    else i++;
                }
            }
            return -1;
        }

        private int[] MakeNext(char[] arr)
        {
            var n = arr.Length;
            var lps = new int[n];
            lps[0] = 0;
            for (int i = 1, len = 0; i < n;)
                if (arr[i] == arr[len])
                    lps[i++] = ++len;
                else if (len != 0) len = lps[len - 1];
                else lps[i++] = 0;
            return lps;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    class Find_Smallest_Letter_Greater_Than_Target
    {
        public char NextGreatestLetter(char[] letters, char target)
        {
            int lo = 0, hi = letters.Length;
            while (lo < hi)
            {
                int mi = lo + (hi - lo) / 2;
                if (letters[mi] <= target) lo = mi + 1;
                else hi = mi;
            }
            return letters[lo % letters.Length];
        }
    }
}

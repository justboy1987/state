using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sort
{
    public class MergeSortSolution
    {
        public static void Sort(int[]a, int s, int e)
        {
            if (s < e)
            {
                var mid = (s + e) / 2;
                Sort(a, s, mid);
                Sort(a , mid+1, e);
                MergeMethod(a, s, mid, e);
            }
        }

        private static void MergeMethod(int[]a, int s, int m, int e)
        {
            var t = new int[e - s + 1];
            int i = s, j = m + 1, k = 0;
            while (i <= m && j <= e)
            {
                if (a[i] < a[j])
                {
                    t[k++] = a[i++];
                }
                else
                {
                    t[k++] = a[j++];
                }
            }

            while(i <=m) t[k++] = a[i++];
            while(j <= e) t[k++] = a[j++];
            for (k = 0, i = s; i <= e;)
            {
                a[i++] = t[k++];
            }
        }
    }
}

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sort
{
    class QuickSortSolution
    {
        public static void QuickSort(int[]a, int s, int e)
        {
            if (s < e)
            {
                int pos = Partition(a, s, e);
                QuickSort(a, s, pos -1);
                QuickSort(a, pos+1, e);
            }
        }

        private static int Partition(int[] a, int s, int e)
        {
            var pivot = a[s];
            while (s < e)
            {
                while (s < e & a[e] > pivot) e--;
                a[s] = a[e];
                while (s < e & a[s] < pivot) s++;
                a[e] = a[s];
            }
            a[s] = pivot;
            return s;
        }


        public static int QuickSeleckKth(int[] a, int k)
        {
            int begin = 0, end = a.Length;
            int traget = 0;
            while (begin < end)
            {
                var pos = Partition(a, begin, end);
                if (pos == k - 1)
                {
                    traget = a[pos];
                    break;
                }else if (pos > k - 1)
                {
                    end = pos - 1;
                }
                else
                {
                    begin = pos + 1;
                }
            }
            return traget;

        }
    }
}

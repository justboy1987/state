using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sort
{
    class HeadSortSLN
    {
        private static void BuildHeap(int[]h, int length)
        {
            for (int i = (length - 1) / 2; i >= 0; i--)
            {
                HeapAdjust(h, i , length);
            } 
        }

        public void HeapSort(int[] h, int length)
        {
            BuildHeap(h, length);
            for (int i = length - 1; i > 0; i--)
            {
                Swap(h, i, 0);
                HeapAdjust(h,0,i);
            }
        }
        private static void HeapAdjust(int[]h, int s, int length)
        {
            int temp = h[s];
            int child = 2 * s + 1; // left child
            while (child < length)
            {
                if (child + 1 < length && h[child] < h[child + 1])
                {
                    ++child;
                }
                if (h[s] < h[child])
                {
                    h[s] = h[child];
                    s = child;
                    child = 2 * s + 1;
                }
                else
                {
                    break;
                }
            }
            h[s] = temp;
        }

        private static void Swap(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[n] = temporary;
        }
    }
}

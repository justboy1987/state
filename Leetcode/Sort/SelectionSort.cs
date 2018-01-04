using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sort
{
    public class SelectionSort
    {
        public int[] Sort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int k = IntArrayMin(array, i);
                if (i != k)
                    exchange(array, i, k);
            }
            return array;
        }

        private static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        private static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[n] = temporary;
        }
    }
}

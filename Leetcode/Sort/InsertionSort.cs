using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sort
{
    public class InsertionSort
    {
        public int[] Sort(int[] array)
        {
            for (var j = 1; j < array.Length; j++)
            {
                for (var i = j; i > 0 && array[i] < array[i - 1]; i--)
                {
                    exchange(array, i, i - 1);
                }
            }
            return array;
        }

        private static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[n] = temporary;
        }
    }
}

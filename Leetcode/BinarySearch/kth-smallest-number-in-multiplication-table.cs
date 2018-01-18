using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    class kth_smallest_number_in_multiplication_table
    {
        /// <summary>
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthNumber(int m, int n, int k)
        {
            int low = 1, high = m * n;

            while (low < high)
            {
                int mid = low + (high - low) / 2;
                int c = Count(mid, m, n);
                if (c >= k) high = mid; //因为可以是 mid 所以不减1
                else low = mid + 1;
                
            }

            return high;
        }

        private int Count(int v, int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                int temp = Math.Min(v / i, n);
                count += temp;
            }
            return count;
        }
    }
}

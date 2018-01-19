using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    class Kth_Smallest_Element_in_a_Sorted_Matrix
    {
        public int KthSmallest(int[,] matrix, int k)
        {
            int lo = matrix[0,0], hi = matrix[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1] + 1;//[lo, hi)
            while (lo < hi)
            {
                int mid = lo + (hi - lo) / 2;
                int count = 0, j = matrix.GetLength(1) - 1;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    while (j >= 0 && matrix[i,j] > mid) j--;
                    count += (j + 1);
                }
                if (count < k) lo = mid + 1;   //[mid +1 , hi)
                else hi = mid;                 //[lo, mid)
            }
            return lo;
        }
    }
}

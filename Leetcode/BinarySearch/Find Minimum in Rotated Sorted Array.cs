using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    class Find_Minimum_in_Rotated_Sorted_Array
    {
        public int FindMin(int[] nums)
        {
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (nums[mid] > nums[hi]) lo = mid + 1;
                else hi = mid;
            }
            return nums[lo];
        }
        
    }
}

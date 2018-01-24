using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    /// <summary>
    /// https://leetcode.com/problems/search-for-a-range/description/
    /// </summary>
    class Search_for_a_Range
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] targetRange = { -1, -1 };

            int leftIdx = ExtremeInsertionIndex(nums, target, true);

            // assert that `leftIdx` is within the array bounds and that `target`
            // is actually in `nums`.
            if (leftIdx == nums.Length || nums[leftIdx] != target)
            {
                return targetRange;
            }

            targetRange[0] = leftIdx;
            targetRange[1] = ExtremeInsertionIndex(nums, target, false) - 1;

            return targetRange;
        }

        // returns leftmost (or rightmost) index at which `target` should be
        // inserted in sorted array `nums` via binary search.
        private int ExtremeInsertionIndex(int[] nums, int target, bool left)
        {
            int lo = 0;
            int hi = nums.Length;

            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (nums[mid] > target || (left && target == nums[mid]))
                {
                    hi = mid;
                }
                else
                {
                    lo = mid + 1;
                 }
            }

            return lo;
        }
    }
}

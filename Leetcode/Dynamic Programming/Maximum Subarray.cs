using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/description/
    /// </summary>
    class Maximum_Subarray
    {
        public int MaxSubArray(int[] nums)
        {
            var max = nums[0];
            var globalMax = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                max = Math.Max(nums[i], nums[i] + max);
                if (max > globalMax) globalMax = max;
            }
            return globalMax;
        }
    }
}

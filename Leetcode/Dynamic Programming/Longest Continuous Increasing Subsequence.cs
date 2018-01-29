using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/longest-continuous-increasing-subsequence/description/
    /// </summary>
    class Longest_Continuous_Increasing_Subsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            int max = 1, pre = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    pre = pre + 1;
                }
                else
                {
                    pre = 1;
                }
                max = Math.Max(pre, max);
            }
            return max;
        }
    }
}

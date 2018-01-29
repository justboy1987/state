using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-longest-increasing-subsequence/description/
    /// </summary>
    class Number_of_Longest_Increasing_Subsequence
    {
        public static int FindNumberOfLIS(int[] nums)
        {
            int N = nums.Length;
            if (N <= 1) return N;
            int[] lengths = new int[N]; //lengths[i] = length of longest ending in nums[i]
            int[] counts = new int[N]; //count[i] = number of longest ending in nums[i]
            for (int i = 0; i < counts.Length; i++)
            {
                counts[i] = 1;
            }

            for (int j = 0; j < N; ++j)
            {
                for (int i = 0; i < j; ++i) if (nums[i] < nums[j])
                {
                    if (lengths[i] >= lengths[j])
                    {
                        lengths[j] = lengths[i] + 1;
                        counts[j] = counts[i];
                    }
                    else if (lengths[i] + 1 == lengths[j])
                    {
                        counts[j] += counts[i];
                    }
                }
            }

            int longest = lengths.Max(), ans = 0;
            for (int i = 0; i < N; ++i)
            {
                if (lengths[i] == longest)
                {
                    ans += counts[i];
                }
            }
            return ans;
        }
    }
}

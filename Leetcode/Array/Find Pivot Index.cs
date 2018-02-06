using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Array
{
    /// <summary>
    /// https://leetcode.com/problems/find-pivot-index/description/
    /// </summary>
    class Find_Pivot_Index
    {
        public int PivotIndex(int[] nums)
        {
            int sum = nums.Sum(), leftsum = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (leftsum == sum - leftsum - nums[i]) return i;
                leftsum += nums[i];
            }
            return -1;
        }
    }
}

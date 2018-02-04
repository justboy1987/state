using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Array
{
    class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            System.Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i == 0 || (i > 0 && nums[i] != nums[i - 1])) // remove duplication
                {
                    int lo = i + 1, hi = nums.Length - 1, sum = 0 - nums[i];
                    while (lo < hi)
                    {
                        if (nums[lo] + nums[hi] == sum)
                        {
                            result.Add(new List<int>() { nums[i], nums[lo], nums[hi]});
                            while (lo < hi && nums[lo] == nums[lo + 1]) lo++; // remove duplication
                            while (lo < hi && nums[hi] == nums[hi - 1]) hi--; // remove duplication
                            lo++; hi--;
                        }
                        else if (nums[lo] + nums[hi] < sum) lo++;
                        else hi--;
                    }
                }
            }
            return result;
        }
    }
}

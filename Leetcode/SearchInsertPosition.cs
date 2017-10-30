using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            var l = 0; var r = nums.Length - 1;
            while (l < r)
            {
                var mid = l + (r - l) / 2;
                if(nums[mid] == target)
                {
                    return mid;
                }else if(nums[mid] < target)
                {
                    l = mid + 1;
                }else
                {
                    r = mid - 1;
                }
            }
            if(l == nums.Length - 1 && nums[l] < target)
            {
                return l + 1;
            }
            return l;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class RemoveElement
    {
        public static int RemoveElement2(int[] nums, int val)
        {
            if(nums == null || nums.Length == 0)
            {
                return 0;
            }
            var l = 0; var r = nums.Length - 1;
            while(l < r)
            {
                while (l < r && nums[l] != val) l++;
                while (l < r && nums[r] == val) r--;
                if(l != r)
                {
                    var temp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = temp;
                    l++; r--;
                }
                else
                {
                    break;
                }
            }
            return nums[l] != val ? l + 1:l ;
        }
    }
}
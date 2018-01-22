using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    /// <summary>
    /// The array may contain duplicates.
    /// </summary>
    class Search_in_Rotated_Sorted_Array_II
    {
        public bool Search(int[] nums, int target)
        {
            int l = 0, h = nums.Length - 1;
            while (l <= h)
            {
                var mid = (l + h) / 2;
                if (nums[mid] == target) return true;

                if (nums[mid] > nums[h])
                {
                    if (target >= nums[l] && target < nums[mid])
                    {
                        h = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
                
                else if (nums[mid] < nums[h])
                {
                    if (target > nums[mid] && target <= nums[h])
                    {
                        l = mid + 1;
                    }
                    else
                    {
                        h = mid - 1;
                    }
                }
                else
                {
                    h--;
                }
            }
            return false;
        }

    }
}

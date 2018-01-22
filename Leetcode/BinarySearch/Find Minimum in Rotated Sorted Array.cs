using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.BinarySearch
{
    class Find_Minimum_in_Rotated_Sorted_Array
    {
        public static int FindMin(int[] nums)
        {// 有重复的情况是错的
            int lo = 0, hi = nums.Length - 1;
            while (lo < hi)
            {
                int mid = (lo + hi) / 2;
                if (nums[mid] > nums[hi]) lo = mid + 1;
                else hi = mid;
            }
            return nums[lo];
        }

        public static int FindMin2(int[] nums)
        {
            int l = 0, r = nums.Length - 1;
            while (l < r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] < nums[r])
                {
                    r = mid;
                }
                else if (nums[mid] > nums[r])
                {
                    l = mid + 1;
                }
                else
                {
                    r--;  //nums[mid]=nums[r] no idea, but we can eliminate nums[r];
                }
            }
            return nums[l];
        }


        public static int FindMin3(int[] nums)
        {
            int l = 0, r = nums.Length - 1;
            while (l < r)
            {
                int mid = (l + r) / 2;
                if (nums[mid] < nums[l])
                {
                    l = mid;
                }
                else if (nums[mid] > nums[l])
                {
                    r = mid - 1;
                }
                else
                {
                    l++;  //nums[mid]=nums[l] no idea, but we can eliminate nums[l];
                }
            }
            return nums[l];
        }
    }
}

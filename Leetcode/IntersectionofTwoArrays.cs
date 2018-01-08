using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class IntersectionofTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var numbers = new HashSet<int>();
            foreach (var n in nums1)
            {
                numbers.Add(n);
            }
            var ret = new HashSet<int>();
            foreach (var n in nums2)
            {
                if (numbers.Contains(n))
                {
                    ret.Add(n);
                }
            }
            return ret.ToArray();
        }
    }
}

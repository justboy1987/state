using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Dynamic_Programming
{
    /// <summary>
    /// https://leetcode.com/problems/house-robber/description/
    /// </summary>
    class House_Robber
    {
        public int Rob(int[] nums)
        {
            int prevNo = 0;
            int prevYes = 0;
            foreach (var n in nums)
            {
                int temp = prevNo;
                prevNo = Math.Max(prevNo, prevYes);
                prevYes = n + temp;
            }
            return Math.Max(prevNo, prevYes);
        }
    }
}

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

        public int rob(int[] num)
        {
            int rob = 0; //max monney can get if rob current house
            int notrob = 0; //max money can get if not rob current house
            for (int i = 0; i < num.Length; i++)
            {
                int currob = notrob + num[i]; //if rob current value, previous house must not be robbed
                notrob = Math.Max(notrob, rob); //if not rob ith house, take the max value of robbed (i-1)th house and not rob (i-1)th house
                rob = currob;
            }
            return Math.Max(rob, notrob);
        }
    }
}
